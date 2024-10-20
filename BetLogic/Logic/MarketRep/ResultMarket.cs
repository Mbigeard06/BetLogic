using BetLogic.Logic.BetRep;
using BetLogic.Logic.MarketAgregator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.MarketRep
{
    internal class ResultMarket : Market
    {
        public override double getBetRob(Outcome outcome, BetInMarket betInMarket, bool laid)
        {
            throw new NotImplementedException();
        }

        public override double getLayLiability(Outcome outcome)
        {
            throw new NotImplementedException();
        }
    }
}
