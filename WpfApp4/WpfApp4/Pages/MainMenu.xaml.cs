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
using WpfApp4.ApplicationData;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnDishes_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new TovarPage());
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new KategoriiPage());
        }
    }
}
