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

namespace Levykin.i.m
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Здесь должна быть логика загрузки пользователей из вашего источника данных
            var users = new List<User>
            {
                new User { Lastname = "Иванов", firstname = "Иван", role = "Администратор", username = "ivanov", IsLocked = false },
                new User { Lastname = "Петрова", firstname = "Мария", role = "Пользователь", username = "petrova", IsLocked = true }
            };

            Users.ItemsSource = users;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            // Логика добавления нового пользователя
            MessageBox.Show("Функция добавления пользователя");
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (Users.SelectedItem != null)
            {
                // Логика удаления выбранного пользователя
                MessageBox.Show("Пользователь будет удален");
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // Логика сохранения изменений
            MessageBox.Show("Изменения сохранены");
        }
    }

    public class User
    {
        public string Lastname { get; set; }
        public string firstname { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public bool IsLocked { get; set; }
    }  
    }
}
