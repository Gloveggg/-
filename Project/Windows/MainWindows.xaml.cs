using Project.View;
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
using System.Windows.Shapes;

namespace Project.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new RecordPage());
        }

        private void Klients_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new KlientsPage());
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ServicePage());
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new MaterialsPage());
        }

        private void Barber_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new BarberPage());
        }
    }
}
