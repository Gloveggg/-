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
    /// Логика взаимодействия для AddRecordPage.xaml
    /// </summary>
    public partial class AddRecordPage : Page
    {
        public AddRecordPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.bs.barberEntities.Record1.Add(new Model.Record1()
            { 
                Serviceid = Convert.ToInt32(this.serviceid.Text),
                Clientid = Convert.ToInt32(this.clientid.Text),
                Materialsid = Convert.ToInt32(this.materialid.Text),
                Barberid = Convert.ToInt32(this.barberid.Text),
                DataAndTime = Convert.ToDateTime( this.dataandtime.Text),
                Comment = this.comment.Text });

            AppData.bs.barberEntities.SaveChanges();

            NavigationService.Navigate(new RecordPage());

        }
    }
}
