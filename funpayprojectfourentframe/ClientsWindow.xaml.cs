using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace funpayprojectfourentframe
{

    public partial class ClientsWindow : Window
    {
        private LastChangeFourPrgFunPayEntities entifunpay = new LastChangeFourPrgFunPayEntities(); 

        public ClientsWindow()
        {
            InitializeComponent();
            ClientsDataGrid.ItemsSource = entifunpay.Clients.ToList();
            comboBox.ItemsSource = entifunpay.Clients.ToList();
        }

      

        private void ButtonBackClient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            ClientsDataGrid.ItemsSource = entifunpay.Clients.ToList().Where(item => item.ClientFirstName.ToLower().Contains(SearchTextBox.Text.ToLower()));

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {

                var select = comboBox.SelectedItem as Clients;
                ClientsDataGrid.ItemsSource = entifunpay.Clients.ToList().Where(item =>  item.ClientFirstName == select.ClientFirstName);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            comboBox.SelectedItem = null;
            ClientsDataGrid.ItemsSource = entifunpay.Clients.ToList();
        }
    }
}
