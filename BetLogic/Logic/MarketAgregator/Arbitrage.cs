using BetLogic.Logic.BetRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.MarketAgregator
{
    /// <summary>
    /// Represent an Arbitrage opportunitiess 
    /// </summary>
    public class Arbitrage
    {
        private Outcome outcome;
        private double arbitrageRoi;
        
        /// <summary>
        /// Getter
        /// </summary>
        public double ArbitrageRoi { get { return arbitrageRoi;  } }

        /// <summary>
        /// Arbitrage constructor
        /// </summary>
        /// <param name="outcome">outcome concerned by the arbitrage</param>
        /// <param name="arbitrageRoi">Roi of the arbitrage %</param>
        public Arbitrage(Outcome outcome, double arbitrageRoi)
        {
            this.outcome = outcome;
            this.arbitrageRoi = arbitrageRoi;
        }
    }
}
