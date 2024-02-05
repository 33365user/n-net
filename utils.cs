using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace n_net_poker
{
    internal class utils
    {
        /**
         * 
         * ReturnRandomDouble
         * 
         * Who would have known in the year of our lord 2024, you would need to have your own method to call a random double
         * 
         * Takes a double as a variable, which is responsible for multiplying with the random number.
         * 
         */
        public double returnRandomDouble(double modifier)
        {
            Random r = new Random();
            Thread.Sleep(1);//this had to be added as without this, too small a loop would return the same double because the random util uses timestamps

            return (r.NextDouble() * modifier);
        }
    }
}
