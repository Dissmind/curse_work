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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void EmploersListOpenWindow(object sender, RoutedEventArgs e)
        {

        }

        private void MedWatchListOpenWindow(object sender, RoutedEventArgs e)
        {

        }

        private void MedWatchAddOpenWindow(object sender, RoutedEventArgs e)
        {
            new MedWatchAddWindow().ShowDialog();
        }
    }
}
