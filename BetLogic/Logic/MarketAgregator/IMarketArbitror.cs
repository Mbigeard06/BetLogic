using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetLogic.Logic.MarketRep;

namespace BetLogic.Logic.MarketAgregator
{
    internal interface IMarketArbitror
    {
        /// <summary>
        /// Check if there are possible arbitrage opportunites in the market
        /// </summary>
        /// <returns>Arbitrage opportunity</returns>
        public abstract Arbitrage IsArbitrage(Market market1, Market market2);
    }
}
