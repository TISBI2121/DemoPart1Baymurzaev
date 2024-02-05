using KR2_Baymurzaev.Models;
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

namespace KR2_Baymurzaev.Windows
{
    /// <summary>
    /// Логика взаимодействия для TaskUserAddWindow.xaml
    /// </summary>
    public partial class TaskUserAddWindow : Window
    {
        Models.Task contextTask;
        public TaskUserAddWindow(Models.Task task)
        {
            InitializeComponent();
            CBUser.ItemsSource = App.db.User.Where(x => x.DepartamentId == App.loginedUser.DepartamentId).ToList();
            contextTask = task;
        }

        private void BRegiste_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = CBUser.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Вы не выбрали сотрудника");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBDescription.Text))
            {
                MessageBox.Show("Вы не заполнили описание задачи");
                return;
            }
            contextTask.TaskUser.Add(new TaskUser() { User = selectedUser, Description = TBDescription.Text, Task = contextTask, Starus = false});
            App.db.SaveChanges();
            MessageBox.Show("Успешно");
            App.Current.MainWindow.Focus();
            this.Close();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
