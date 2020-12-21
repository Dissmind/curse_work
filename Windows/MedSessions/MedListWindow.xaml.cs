using curse_work.Windows;
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

namespace curse_work
{
    /// <summary>
    /// Логика взаимодействия для MedListWindow.xaml
    /// </summary>
    public partial class MedListWindow : Window
    {
        public MedListWindow()
        {
            InitializeComponent();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            new DeleteMedWatchWindow().ShowDialog();
        }


        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new MedWatchAddWindow().ShowDialog();
        }
    }
}
