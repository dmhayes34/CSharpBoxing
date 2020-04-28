using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public static class AI
    {
        //AI needs to select a choice randomly
        public static string Decision()
        {
            var Rand = new Random();
            var Decisions = new[] { "J", "U", "H", "B", "S", "D" };

            string Decision = Decisions[Rand.Next(0, 6)];

            return Decision;
        }

       

    }
}

