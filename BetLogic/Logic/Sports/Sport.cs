using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.Sports
{
    /// <summary>
    /// Represent a sport
    /// </summary>
    public abstract class Sport
    {
        /// <summary>
        /// Sport name
        /// </summary>
        private string sportName;

        public string SportName { get { return sportName; } }

        /// <summary>
        /// If true, it means that a bet on this sport has 3 possible outcomes (win, lose, draw).
        /// </summary>
        private bool draw;
        public bool Draw { get { return draw; } }

        public Sport(string sportName, bool draw)
        {
            this.sportName = sportName;
            this.draw = draw;
        }
    }

}
