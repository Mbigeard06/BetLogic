using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetLogic.Logic.Sports
{
    /// <summary>
    /// Represent football
    /// </summary>
    internal class Football : Sport
    {
        public Football(bool draw) : base("Football", draw) { }
    }
}
