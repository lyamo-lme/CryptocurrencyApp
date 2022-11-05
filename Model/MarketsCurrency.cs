using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class MarketsCurrency
    {
        public string ExchangeId { get; set; }
        public string BaseId { get; set; }
        public string QuoteId { get; set; }
        public string BaseSymbol { get; set; }
        public decimal PriceUsd { get; set; }
        public decimal VolumePercent { get; set; }
        public decimal VolumeUsd24Hr { get; set; }
    }
}
