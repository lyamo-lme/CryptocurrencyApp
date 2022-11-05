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
        public bool UpdateAble = true;
        public Table(Frame? parentFrame)
        {

            InitializeComponent();
            CountElement.Text = "10";
            ParentFrame = parentFrame;
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Loaded;
            timer.Start();
           
        }
        private async void Loaded(object sender, EventArgs e)
        {
            if(UpdateAble)
            await UpdateTable();
        }

        private async Task UpdateTable()
        {
            await FetchData();
            FillTable(GetCountCryptByTextElem());
        }

        private List<Cryptocurrency> GetCountCryptByTextElem() {

            if (int.TryParse(CountElement.Text, out int newCount))
            {
                int maxCount = DataApp.cryptocurrencies.Count;
                if (!CountElement.Text.Equals(""))
                {
                    return DataApp.GetCountFromBegin(newCount >= maxCount ? maxCount : newCount);
                }
            }
            return (List<Cryptocurrency>)CurrencyTable.ItemsSource;
        }
        private void FillTable(List<Cryptocurrency> list)
        {
            CurrencyTable.ItemsSource = list;
        }

        public void SelectItem(object sender, MouseButtonEventArgs e)
        {
            if (ParentFrame != null)
            {
                Cryptocurrency cryptocurrency = CurrencyTable.SelectedItem as Cryptocurrency;
                ChangeParentFrame(new Cryptos(cryptocurrency));
            }
        }
        private void ChangeParentFrame(Page page) {
            ParentFrame.Content = page;
        }

        private void CountElement_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillTable(GetCountCryptByTextElem());
        }
        private async Task FetchData()
        {
            DataApp.cryptocurrencies = await Api.FetchDataAsync<List<Cryptocurrency>>(Api.urlCoinCap + "assets");
        }

        private void MainGrid_Loaded(object sender, EventArgs e)
        {

        }

        private void FindElement_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Find.Text.Equals(""))
            {
                UpdateAble = false;
                FillTable(DataApp.GetByIdOrNameOrSymbol(Find.Text));
            }
            else {
                UpdateAble = true;
            }
        }
    }
}

