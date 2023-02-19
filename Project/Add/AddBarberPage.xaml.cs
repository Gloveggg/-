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
    /// Логика взаимодействия для AddBarberPage.xaml
    /// </summary>
    public partial class AddBarberPage : Page
    {
        public AddBarberPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            AppData.bs.barberEntities.Barber.Add(new Model.Barber() {  Experince = Convert.ToDecimal(this.experince.Text), Name= this.natName.Text, Information = this.information.Text, Comment = this.comment.Text });

            AppData.bs.barberEntities.SaveChanges();

            NavigationService.Navigate(new BarberPage());
        }
    }
}
