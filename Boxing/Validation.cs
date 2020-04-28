using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public static class Validation
    {
        //Allowing for someone to type the whole word in either upper or lower or mixed case and converting it to one character
        //Since this is the first validation we force Choice to uppercase now for all future reference
        public static string CheckPunchForWord(string Choice)
        {
            Choice = Choice.ToUpper();
            if (Choice == "JAB")
            {
                return "J";
            }
            else if (Choice == "UPPERCUT")
            {
                return "U";
            }
            else if (Choice == "HAYMAKER")
            {
                return "H";
            }
            else if (Choice == "BLOCK")
            {
                return "B";
            }
            else if (Choice == "SIDE STEP")
            {
                return "S";
            }
            else if (Choice == "SIDESTEP")
            {
                return "S";
            }
            else if (Choice == "DUCK")
            {
                return "D";
            }
            else
            {
                return Choice;
            }
        }


        //This is used for the recap screen. Returning the word rather than the letter 
        public static string ChangeChoiceToWord(string Choice)
        {
            if (Choice == "J")
            {
                return "JAB";
            }
            else if (Choice == "U")
            {
                return "UPPERCUT";
            }
            else if (Choice == "H")
            {
                return "HAYMAKER";
            }
            else if (Choice == "B")
            {
                return "BLOCK";
            }
            else if (Choice == "S")
            {
                return "SIDE STEP";
            }
            else if (Choice == "D")
            {
                return "DUCK";
            }
            return "FALSE";
        }


        //validating if the Choice is one of the 6 possible values
        public static bool CheckPunchChoice(string Choice)
        {
            if ((Choice == "J") || (Choice == "U") || (Choice == "H") || 
                (Choice == "B") || (Choice == "D") || (Choice == "S"))
            {
                return true;
            }
                
            return false;
        }


        //overall check of player input first check for word and set uppercase, then prompt for re-entry if it's not one of 6 choices
        public static string InputCheck(string Choice)
        {
            do
            {
                Choice = Validation.CheckPunchForWord(Choice);
                if (!Validation.CheckPunchChoice(Choice))
                {
                    Console.WriteLine("\tInvalid Entry Please Try Again!");
                    Console.Write("\t");
                    Choice = Console.ReadLine();
                };
            } while (!Validation.CheckPunchChoice(Choice));
            return Choice;
        }
    }
}
