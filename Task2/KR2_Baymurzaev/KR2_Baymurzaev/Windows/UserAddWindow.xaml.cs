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
using KR2_Baymurzaev.Models;

namespace KR2_Baymurzaev.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserAddWindow.xaml
    /// </summary>
    public partial class UserAddWindow : Window
    {
        public UserAddWindow()
        {
            InitializeComponent();
            TBFIO.Focus();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            int rate = 0;
            string ex = "";
            if (string.IsNullOrWhiteSpace(TBFIO.Text))
                ex += "Поле ФИО заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBPass.Text) && TBPass.Text.Length > 10)
                ex += "Поле Паспорт заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBAddress.Text))
                ex += "Поле Адрес заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBTelephone.Text) && TBTelephone.Text.Length > 11)
                ex += "Поле Телефон заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBStackDesc.Text))
                ex += "Поле Стек технологий заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBDutiDesc.Text))
                ex += "Поле Обязанности заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBRate.Text) && !int.TryParse(TBRate.Text, out rate))
                ex += "Поле Ставка заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBLogin.Text))
                ex += "Поле Логин заполненно неверно\n";
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
                ex += "Поле Пароль заполненно неверно\n";
            if (!string.IsNullOrWhiteSpace(ex))
            {
                MessageBox.Show(ex);
                return;
            }

            User user = new User()
            {
                FIO = TBFIO.Text,
                Pass = TBPass.Text,
                Address = TBAddress.Text,
                Telephone = TBTelephone.Text,
                StackDescription = TBStackDesc.Text,
                DutiDescription = TBDutiDesc.Text,
                Rate = rate,
                Login = TBLogin.Text,
                Password = TBPassword.Text,
                RoleId = 2,
                DepartamentId = App.loginedUser.DepartamentId
            };

            App.db.User.Add(user);
            App.db.SaveChanges();
            MessageBox.Show("Успешно");
            this.Close();
        }
    }
}
