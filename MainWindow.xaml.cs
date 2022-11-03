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
        public MainWindow()
        {
            InitializeComponent();
        }

        async void Fetch()
        {
            
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://api.coincap.io/v2/assets");
                    var ret = JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync());
                    if (ret != null)
                    {
                        list = JsonConvert.DeserializeObject<List<Cryptocurrency>>(ret["data"].ToString());
                    }
                }
            
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Fetch();
        }
    }
}
