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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project.Add
{
    /// <summary>
    /// Логика взаимодействия для AddServicePage.xaml
    /// </summary>
    public partial class AddServicePage : Page
    {
        public AddServicePage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AppData.bs.barberEntities.Service.Add(new Model.Service() 
            {  
                Price = Convert.ToDecimal(this.price.Text), 
                ServiceName = this.serviceName.Text,  });

            AppData.bs.barberEntities.SaveChanges();

            NavigationService.Navigate(new ServicePage());
        }
    }
}
