
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
    /// Логика взаимодействия для AddKlientPage.xaml
    /// </summary>
    public partial class AddKlientPage : Page
    {
        public AddKlientPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AppData.bs.barberEntities.Client.Add(new Model.Client()
            { 
                BirthDay = this.birthdata.SelectedDate.Value,
                Name = this.natName.Text,
                Peculiarities = this.peculiarities.Text });

            AppData.bs.barberEntities.SaveChanges();

            NavigationService.Navigate(new View.KlientsPage());
        }
    }
}
