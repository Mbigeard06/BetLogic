using BetLogic.Logic.BetRep;
using BetLogic.Logic.MarketAgregator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.MarketRep
{
    public abstract class Market
    {
        /// <summary>
        /// Owner/Bookmarker of the market
        /// </summary>
        private string marketOwner;

        /// <summary>
        /// List of the bet in the market
        /// </summary>
        private List<BetInMarket> bets;
        /// <summary>
        /// Return the bets of the market
        /// </summary>
        public List<BetInMarket> Bets { get { return bets; } }

        /// <summary>
        /// Market fees on the market
        /// </summary>
        private double marketFees;

        /// <summary>
        /// Change a bet's odd
        /// </summary>
        /// <param name="outcome"></param>
        /// <param name="newOdd"></param>
        public void changeBetOdd(Outcome outcome, double newOdd)
        {
            foreach (BetInMarket iBet in bets)
            {
                if(iBet.Bet.Outcome == outcome) //We get the bet that we want to change
                {
                    //Change the odd
                    iBet.Bet.Odd = newOdd;
                }
            }
        }

        /// <summary>
        /// Add a bet in the market
        /// </summary>
        /// <param name="bet"></param>
        public void AddBet(BetInMarket bet)
        {
            this.bets.Add(bet);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marketOwner">owner of the market</param>
        /// <param name="bets">bets</param>
        public Market(string marketOwner, List<BetInMarket> bets)
        {
            this.bets = bets;
            this.marketOwner = marketOwner;
        }

         
    }
}
