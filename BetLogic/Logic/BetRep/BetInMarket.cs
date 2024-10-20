using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.BetRep
{
    internal class BetInMarket
    {
        private Bet bet;
        /// <summary>
        /// Max stake that can be bet (Depend of the markets liquidity)
        /// </summary>
        private int maxStake;

        /// <summary>
        /// maxStake properties
        /// </summary>
        public int MaxStake { get { return  maxStake; }  set { maxStake = value; } }
        /// <summary>
        /// Bet property
        /// </summary>
        public Bet Bet { get { return bet; } }
    }
}
