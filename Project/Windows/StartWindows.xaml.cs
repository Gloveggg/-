using Project.AppData;
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
    /// Логика взаимодействия для StartWindows.xaml
    /// </summary>
    public partial class StartWindows : Window
    {
        Users users = new Users() { Login = "Admin", Password = "123" };
        public StartWindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LoginTb.Text) && !string.IsNullOrWhiteSpace(PasswordTb.Password))
            {
                MessageBox.Show ("Добро пожаловать");
                MainWindows mainWindows = new MainWindows();
                mainWindows.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        private void StartFrm_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
