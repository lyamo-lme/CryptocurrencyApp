using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Cryptocurrency
    {
        public string Id { get; set; }
        public int Rank { get; set; }
        public string Symbol { get;set; }
        public string Name { get;set; }
        public decimal Supply { get;set; }
        public decimal? MaxSupply { get;set; }
        public decimal MarketCapUsd { get;set; }
        public decimal PriceUsd { get;set; }
        public decimal ChangePercent24Hr { get;set; }
        public decimal? VWap24Hr { get;set; }
        public List<HistoryCurrency>? HistoryCurrencies { get; set; }
        public List<MarketsCurrency>? MarketCurrencies { get; set; }
    }
}
