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

namespace curse_work.Windows.Purchases
{
    /// <summary>
    /// Логика взаимодействия для DeleteDoctorWindow.xaml
    /// </summary>
    public partial class DeleteDoctorWindow : Window
    {
        public DeleteDoctorWindow()
        {
            InitializeComponent();

            List<DoctorModel> allData = DoctorsRepository.GetAll();
            var cbList = new List<string>();

            foreach (var i in allData)
            {
                cbList.Add($"{i.Id}. {i.Name}");
            }

            cb.ItemsSource = cbList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cbText = cb.Text;

            string id = cbText.Substring(0, cbText.IndexOf('.'));

            DoctorsRepository.Delete(Int32.Parse(id));

            MessageBox.Show("Запись успешно удалена");
            this.Close();
        }
    }
}
