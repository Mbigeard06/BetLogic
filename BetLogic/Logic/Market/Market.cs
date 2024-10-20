using BetLogic.Logic.BetRep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.Market
{
    public abstract class Market
    {
        /// <summary>
        /// Owner/Bookmarker of the market
        /// </summary>
        private string marketOwner;
        /// <summary>
        /// Liquidity in the market
        /// </summary>
        private double matched;

        /// <summary>
        /// List of the bet in the market
        /// </summary>
        private List<BetInMarket> bets;

        /// <summary>
        /// 
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

        

        
        
    }
}
