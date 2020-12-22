using curse_work.Models;
using curse_work.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace curse_work.Windows
{
    /// <summary>
    /// Логика взаимодействия для DeleteMedWatchWindow.xaml
    /// </summary>
    public partial class DeleteMedWatchWindow : Window
    {
        public DeleteMedWatchWindow()
        {
            InitializeComponent();

            List<MedWatchModel> allData = MedWatchRepository.GetAll();
            var cbList = new List<string>();
            
            foreach (var i in allData)
            {
                cbList.Add($"{i.Id}. {i.Name}. {i.Time}");
            }

            cb.ItemsSource = cbList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cbText = cb.Text;

            string id = cbText.Substring(0, cbText.IndexOf('.'));

            MedWatchRepository.Delete(Int32.Parse(id));
        }
    }
}
