using BetLogic.Logic.Sports;

namespace BetLogic.Logic.BetRep
{
    public class Bet
    {
        #region Attributs
        private const int stake = 1;
        private Sport sport;
        private double odd;
        private bool boosted;
        private Outcome outcome;
        #endregion

        #region Properties
        public Sport Sport { get { return sport; } }
        public double Odd { get { return odd; } set { odd = value; }}
        public bool Boosted { get { return boosted; } }
        public Outcome Outcome { get { return outcome; } }
        #endregion

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="sport">bet's sport</param>
        /// <param name="odd">bet's odd</param>
        /// <param name="boosted">True if odd boosted</param>
        /// <param name="outcome"></param>
        public Bet(Sport sport, double odd, bool boosted, Outcome outcome)
        {
            this.sport = sport;
            this.odd = odd;
            this.boosted = boosted;
            this.outcome = outcome;
        }

        public override string ToString()
        {
            return "Outcom : " + outcome + " odd : " + odd;
        }


    }
}
