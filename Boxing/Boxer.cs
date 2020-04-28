using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public class Boxer
    {
        //variables
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public string Choice { get; set; }
        const double Low = 0.5;
        const double Med = 1.5;
        const int MidRange = 2;
        const double High = 2.5;
        const double Ultra = 3.5;

        //constructor
        public Boxer()
        {
            Health = 250;
            Stamina = 250;
            Strength = 20;
            Speed = 30;
            Choice = "J";
        }

        //punch methods  These are dependent on if the opponent counters or not.  they impact both the fighter and opponent.
        public void Jab(Boxer Opponent)
        {
            if (Opponent.Choice == "B")
            {
                Stamina -= (int)(this.Strength * Low);
            }
            else
            {
                Opponent.Health -= (int)(this.Strength * Low);
                Stamina -= (int)(this.Strength * Low);
            }
        }

        public void Uppercut(Boxer Opponent)
        {
            if (Opponent.Choice == "B")
            {
                Opponent.Health -= (int)(this.Strength * Low); //blocked a piece of the Uppercut
                Stamina -= (int)(this.Strength * Med);
            }
            else if (Opponent.Choice == "S")
            {
                Stamina -= (int)(this.Strength * Med); // No damage for sidestepping away
            }
            else if (Opponent.Choice == "D")
            {
                Opponent.Health -= (int)(this.Strength * High);//Ducked into an uppercut extra damage
                Stamina -= (int)(this.Strength * Med);
            }
            else
            {
                Opponent.Health -= (int)(this.Strength * Med);
                Stamina -= (int)(this.Strength * Med);
            }
        }

        public void Haymaker(Boxer Opponent)
        {
            if (Opponent.Choice == "S")
            {
                Opponent.Health -= (int)(this.Strength * Ultra);   //Side Stepped into a Haymaker extra damage
                Stamina -= (int)(this.Strength * High); 
            }
            else if (Opponent.Choice == "D")
            {                                                
                Stamina -= (int)(this.Strength * High); //Ducked under a Haymaker no damage
            }
            else
            {
                Opponent.Health -= (int)(this.Strength * High);  //Haymaker comes around the block normal damage
                Stamina -= (int)(this.Strength * High);
            }
        }

        //counter methods are only dependent on the Fighter who calls them.  They affect the outcome of the other fighters punches.
        public void Block()
        {
            Stamina += Speed;  //Stamina recovery on Block
        }

        public void SideStep()
        {
            Stamina -= Speed;  //Stamina spent on SideStep
        }

        public void Duck()
        {
            Stamina -= Speed * MidRange;  //Stamina spent on HideStep
        }
    }
}
