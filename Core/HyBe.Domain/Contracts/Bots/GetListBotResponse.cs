using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Bots
{
    public class GetListBotResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string predefinedMarket { get; set; }
        public int priceStrategy { get; set; }
        public string tradeType { get; set; }
        public string Assets { get; set; }
        public string Strategy { get; set; }
        public string Formation { get; set; }
        public string trendStrategy { get; set; }
        public int priceVolume { get; set; }
    }
}
