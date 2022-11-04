﻿using System;
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
using TestTask.Model;

namespace TestTask.Frames
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
            CountElement.Text = "10";
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            FillTable();
        }
        private void FillTable()
        {

            if (int.TryParse(CountElement.Text, out int newCount))
            {
                int maxCount = DataApp.cryptocurrencies.Count;
                if (!CountElement.Text.Equals(""))
                {
                    CurrencyTable.ItemsSource = DataApp.GetCountFromBegin(newCount >= maxCount ? maxCount : newCount);
                 
                }
            }
           
        }

        private void SelectItem(object sender, MouseButtonEventArgs e)
        {
            Cryptocurrency path = CurrencyTable.SelectedItem as Cryptocurrency;
        }

        private void CountElement_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillTable();
        }
    }
}
