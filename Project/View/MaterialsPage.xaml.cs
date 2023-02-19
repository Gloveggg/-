﻿using Project.Windows;
using System;
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

namespace Project.View
{
    /// <summary>
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Page
    {
        
        public MaterialsPage()
        {
            InitializeComponent();
            listviewUsers.ItemsSource = AppData.bs.barberEntities.Materials.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMateralPage());
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            StartWindows startWindows = new StartWindows();

            startWindows.Show();


        }
    }
}
