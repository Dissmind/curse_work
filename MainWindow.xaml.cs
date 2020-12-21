using curse_work.Models;
using curse_work.Repository;
using curse_work.Windows;
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

namespace curse_work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new User(
                Login.Text,
                Password.Text
            );

            bool status = UserRepository.Login(user);

            if (status)
            {
                MessageBox.Show("Авторизация прошла успешно!");

                new MenuWindow().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль. Повторите попытку!");
            }
        }
    }
}
