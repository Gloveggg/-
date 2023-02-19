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
    /// Логика взаимодействия для AddMateralPage.xaml
    /// </summary>
    public partial class AddMateralPage : Page
    {
        public AddMateralPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.bs.barberEntities.Materials.Add(new Model.Materials() { Volume = Convert.ToDecimal(this.volume.Text), Product = this.natName.Text });

            AppData.bs.barberEntities.SaveChanges();

            NavigationService.Navigate(new MaterialsPage());

        }
    }
}
