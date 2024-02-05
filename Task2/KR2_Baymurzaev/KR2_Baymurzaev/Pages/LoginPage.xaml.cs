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
using KR2_Baymurzaev.Models;

namespace KR2_Baymurzaev.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            TBLogin.Focus();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = App.db.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == PBPassword.Password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            App.loginedUser = user;
            switch (user.RoleId)
            {
                case 1: NavigationService.Navigate(new ManagerMainPage());
                    break;
                case 2: NavigationService.Navigate(new ProgrammerMainPage());
                    break;
            }
        }
    }
}
