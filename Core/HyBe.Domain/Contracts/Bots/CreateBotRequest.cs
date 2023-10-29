using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Bots
{
    public class CreateBotRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Market Market { get; set; }
        public OrderType OrderType { get; set; }
        public Side Side { get; set; }
        public TrendStrategy TrendStrategy { get; set; }
        public int[] AssetIds { get; set; }
        public int[]? StrategyIds { get; set; }
        public int[]? FormationIds { get; set; }
        public decimal PriceVolume { get; set; }
        public BotOptions BotOptions { get; set; }
        public string MemberId { get; set; }
    }
}
