﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace funpayprojectfourentframe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

        }



        private void ShowFullTable_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void ShowClients_Click(object sender, RoutedEventArgs e)
        {
            ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            this.Close();
        }

        private void ShowReviews_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void ShowSellers_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
