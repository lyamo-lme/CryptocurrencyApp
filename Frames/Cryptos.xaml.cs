using System;
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
    /// Логика взаимодействия для Cryptos.xaml
    /// </summary>
    public partial class Cryptos : Page
    {
        private Cryptocurrency cryptocurrency { get; set; }
        public Cryptos(Cryptocurrency cryptocurrency)
        {
            InitializeComponent();
            this.cryptocurrency = cryptocurrency;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Fetch();
        }
        private async Task Fetch()
        {
           cryptocurrency =  await Api.FetchDataAsync<Cryptocurrency>(Api.urlCoinCap + $"assets/{cryptocurrency.Id}");
        }
    }
}
