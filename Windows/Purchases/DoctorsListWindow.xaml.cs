using curse_work.Models;
using curse_work.Repository;
using curse_work.Windows.Purchases;
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
    /// Логика взаимодействия для DoctorsListWindow.xaml
    /// </summary>
    public partial class DoctorsListWindow : Window
    {
        private void UpdateTable()
        {
            List<DoctorModel> doctorsList = DoctorsRepository.GetAll();
            doctorsGrid.ItemsSource = doctorsList;
        }

        public DoctorsListWindow()
        {
            InitializeComponent();

            UpdateTable();
        }


        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            new DeleteDoctorWindow().ShowDialog();
            UpdateTable();
        }


        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new AddDoctorWindow().ShowDialog();
            UpdateTable();
        }
    }
}
