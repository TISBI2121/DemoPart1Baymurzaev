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

namespace KR2_Baymurzaev.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserListPage.xaml
    /// </summary>
    public partial class UserListPage : Page
    {
        public UserListPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            var filter = App.db.User.Where(x => x.RoleId == 2 && x.DepartamentId == App.loginedUser.DepartamentId);
            string search = TBSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(search))
                filter = filter.Where(x => x.FIO.ToLower().Contains(search));
            DGUsers.ItemsSource = filter.ToList();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            new Windows.UserAddWindow().Show();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void BBack_Click()
        {

        }
    }
}
