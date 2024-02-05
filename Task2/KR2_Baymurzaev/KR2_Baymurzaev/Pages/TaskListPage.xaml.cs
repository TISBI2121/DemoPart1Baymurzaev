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
    /// Логика взаимодействия для TaskListPage.xaml
    /// </summary>
    public partial class TaskListPage : Page
    {
        public TaskListPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            var filter = App.db.Task.Where(x => x.DepartamentId == App.loginedUser.DepartamentId);
            string search = TBSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(search))
                filter = filter.Where(x => x.Requirement.ToLower().Contains(search));
            DGTasks.ItemsSource = filter.ToList();
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Models.Task selected = DGTasks.SelectedItem as Models.Task;
            if (selected == null)
            {
                MessageBox.Show("Вы ничего не выбрали");
                return;
            }
            new Windows.TaskUserAddWindow(selected).Show();
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
