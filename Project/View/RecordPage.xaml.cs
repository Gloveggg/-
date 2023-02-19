

using Project.AppData;
using Project.Model;
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
    /// Логика взаимодействия для RecordPage.xaml
    /// </summary>
    public partial class RecordPage : Page
    {
        public List<Class1> user = new List<Class1>();
        public RecordPage()
        {
            InitializeComponent();
            listviewUsers.ItemsSource = AppData.bs.barberEntities.Record1.ToList();
            genderFilter.ItemsSource = AppData.bs.barberEntities.Service.ToList();
        }
        

        private void genderFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (genderFilter.SelectedItem is Service service)
            {
            listviewUsers.ItemsSource = AppData.bs.barberEntities.Record1.Where(i => i.Serviceid == service.id).ToList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new Add.AddRecordPage());
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StartWindows startWindows = new StartWindows();
             
            startWindows.Show();


        }
    }

}
