using OxyPlot.Wpf;
using System.Collections.Generic;
using OxyPlot;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TestTask.Model;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Windows.Documents;
using System;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using TestTask.Extensions;

namespace TestTask.Frames
{
    /// <summary>
    /// Логика взаимодействия для Cryptos.xaml
    /// </summary>
    public partial class Cryptos : Page
    {
        private bool firstLoad = true;

        private Cryptocurrency cryptocurrency { get; set; }
        public Cryptos(Cryptocurrency cryptocurrency)
        {
            InitializeComponent();
            this.cryptocurrency = cryptocurrency;
            DataContext = this.cryptocurrency;
        }
        private async void TickLoading(object sender, EventArgs e)
        {
            ProgressBar.IsIndeterminate = true;
            await UpdateData();
            ProgressBar.IsIndeterminate = false;

        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeLoadingState(true);
            await UpdateData();
            ChangeLoadingState(false);
        }

        private void ChangeLoadingState(bool state)
        {
            LoadingLayout.Visibility = state ? Visibility.Visible : Visibility.Hidden;
            ProgressBar.IsIndeterminate = state;
        }

        private async Task UpdateData()
        {
            await FetchData();
            UpdateDataTable();
            BindChart();
        }
        private void BindChart() { 
            pm.Model = CandleStickChart.CreateCandlesticksChartModel(cryptocurrency.Candlesticks);
        }

        private void UpdateDataTable()
        {
            HistoryTable.ItemsSource = cryptocurrency.HistoryCurrencies;
            MarketTable.ItemsSource = cryptocurrency.MarketCurrencies;
        }
        private async Task FetchData()
        {
            cryptocurrency = await Api.FetchDataAsync<Cryptocurrency>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}");
            cryptocurrency.HistoryCurrencies = await Api.FetchDataAsync<List<HistoryCurrency>>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}/history?interval=d1");
            cryptocurrency.MarketCurrencies = await Api.FetchDataAsync<List<MarketsCurrency>>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}/markets");
            cryptocurrency.Candlesticks = await Api.FetchDataAsync<List<Candlestick>>(Api.urlCoinCap + $"candles?exchange=poloniex&interval=h8&baseId={cryptocurrency.Id}&quoteId=bitcoin");
        }
    }
}
