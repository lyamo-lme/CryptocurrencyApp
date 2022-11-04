using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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
using TestTask.Frames;
using TestTask.Model;

namespace TestTask
{
    //https://docs.coincap.io/
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cryptocurrency> list = new List<Cryptocurrency>();
        private Api clientApi = new Api();
        public MainWindow()
        {
            InitializeComponent();
        }

        async Task Fetch()
        {
               list =   await clientApi.FetchDataAsync<List<Cryptocurrency>>(Api.urlCoinCap+"assets");
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Fetch();
        }

        private void CryptosPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Cryptos();
        }
        private void MainPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainPage();
        }
    }
}
