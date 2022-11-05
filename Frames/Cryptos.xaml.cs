using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TestTask.Model;

namespace TestTask.Frames
{
    /// <summary>
    /// Логика взаимодействия для Cryptos.xaml
    /// </summary>
    public partial class Cryptos : Page
    {
        private Cryptocurrency cryptocurrency { get; set; }
        public Cryptos(Cryptocurrency cryptocurrency)
        {
            InitializeComponent();
            this.cryptocurrency = cryptocurrency;
            this.DataContext = this.cryptocurrency;
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            await FetchData();
             UpdateDataTable();
        }
        private void UpdateDataTable() {
            HistoryTable.ItemsSource = cryptocurrency.HistoryCurrencies;
            MarketTable.ItemsSource = cryptocurrency.MarketCurrencies;
        }
        private async Task FetchData()
        {
            cryptocurrency = await Api.FetchDataAsync<Cryptocurrency>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}");
            cryptocurrency.HistoryCurrencies = await Api.FetchDataAsync<List<HistoryCurrency>>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}/history?interval=d1");
            cryptocurrency.MarketCurrencies = await Api.FetchDataAsync<List<MarketsCurrency>>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}/markets");
            cryptocurrency.Candlesticks = await Api.FetchDataAsync<List<Candlestick>>(Api.urlCoinCap + $"candles?exchange=poloniex&interval=h4&baseId=ethereum&quoteId={cryptocurrency.Id}");
        }
    }
}
