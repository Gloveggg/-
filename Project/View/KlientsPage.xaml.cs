
using Project.Add;
using Project.Windows;
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
    /// Логика взаимодействия для KlientsPage.xaml
    /// </summary>
    public partial class KlientsPage : Page
    {
        public KlientsPage()
        {
            InitializeComponent();
            listviewUsers.ItemsSource = AppData.bs.barberEntities.Client.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartWindows startWindows = new StartWindows();

            startWindows.Show();


        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddKlientPage());
        }

    }
}
