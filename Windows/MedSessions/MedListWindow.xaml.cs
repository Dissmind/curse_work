﻿using curse_work.Models;
using curse_work.Repository;
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
        private void UpdateTable()
        {
            List<MedWatchModel> medWatchList = MedWatchRepository.GetAll();
            medListGrid.ItemsSource = medWatchList;
        }

        public MedListWindow()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            new DeleteMedWatchWindow().ShowDialog();
            UpdateTable();
        }


        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            new MedWatchAddWindow().ShowDialog();
            UpdateTable();
        }
    }
}
