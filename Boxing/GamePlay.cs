using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public static class GamePlay
    {
        //this determines the outcome of both actions.  if the choice is a punch it affects both the Fighter and Opponent. 
        // If it's a block it only affects the Fighter because the block is resolved in the Fighter's punch
        public static void Resolve(Boxer Fighter, Boxer Opponent)
        {
            if (Fighter.Choice == "J")
            {
                Fighter.Jab(Opponent);
            }
            else if (Fighter.Choice == "U")
            {
                Fighter.Uppercut(Opponent);
            }
            else if (Fighter.Choice == "H")
            {
                Fighter.Haymaker(Opponent);
            }
            else if (Fighter.Choice == "B")
            {
                Fighter.Block();
            }
            else if (Fighter.Choice == "S")
            {
                Fighter.SideStep();
            }
            else if (Fighter.Choice == "D")
            {
                Fighter.Duck();
            }
        }

        public static string CheckForWinner(Boxer Player, Boxer Computer)
        {
            if ((Player.Health < 0) || (Player.Stamina < 0))
            {
                return "\tPlayer Loses!";
            }
            else if  ((Computer.Health < 0) || (Computer.Stamina < 0) )
            {
                return "\tPLAYER WINS!!!!";
            }
            else
            {
                return "";
            }
        }

       

       
    }
}
