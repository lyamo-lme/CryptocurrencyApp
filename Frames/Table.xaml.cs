using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;
using TestTask.Model;

namespace TestTask.Frames
{
    /// <summary>
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Frame? ParentFrame = null;
        public Table(Frame? parentFrame)
        {

            InitializeComponent();
            CountElement.Text = "10";
            ParentFrame = parentFrame;
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Loaded;
            timer.Start();
        }
        private async void Loaded(object sender, EventArgs e)
        {
            await UpdateTable();
        }

        private async Task UpdateTable()
        {
            await Fetch();
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

        public void SelectItem(object sender, MouseButtonEventArgs e)
        {
            if (ParentFrame != null)
            {
                Cryptocurrency cryptocurrency = CurrencyTable.SelectedItem as Cryptocurrency;
                ParentFrame.Content = new Cryptos(cryptocurrency);
            }
        }

        private void CountElement_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillTable();
        }
        private async Task Fetch()
        {
            DataApp.cryptocurrencies = await Api.FetchDataAsync<List<Cryptocurrency>>(Api.urlCoinCap + "assets");
        }

        private void MainGrid_Loaded(object sender, EventArgs e)
        {

        }

    }
}

