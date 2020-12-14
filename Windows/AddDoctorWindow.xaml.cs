using curse_work.Models;
using curse_work.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace curse_work.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddDoctorWindow.xaml
    /// </summary>
    public partial class AddDoctorWindow : Window
    {
        public AddDoctorWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = new DoctorModel
                (
                    $"{Name.Text} {Surname.Text} {SecondName.Text}",
                    Type.Text
                );

            try
            {
                DoctorsRepository.Add(data);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Ошибка, нет доступа к Базе Данных. \n Сообщение ошибки: ${error.Message}");
                this.Close();
                return;
            }

            MessageBox.Show("Запись успешно добавлена в Базу данных.");
            this.Close();
        }
    }
}
