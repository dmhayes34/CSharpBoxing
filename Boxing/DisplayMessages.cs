using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public static class DisplayMessages
    {     

        //Title Page

        public static void Title()
        {            
            Console.Clear();
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║      KK  KK  IIIII  NN    NN   GGGG                     ║");
            Console.WriteLine("\t║      KK KK    III   NNNN  NN  GG                        ║");
            Console.WriteLine("\t║      KKKK     III   NN NN NN  GG  GG                    ║");
            Console.WriteLine("\t║      KK KK    III   NN  NNNN  GG   GG                   ║");
            Console.WriteLine("\t║      KK  KK  IIIII  NN   NNN   GGGGGG                   ║");
            Console.WriteLine("\t║                                                         ║");
            Console.WriteLine("\t║       00000  FFFFF       TTTTTT HH  HH EEEEEE           ║");
            Console.WriteLine("\t║      00   00 FF            TT   HH  HH EE               ║");
            Console.WriteLine("\t║      00   00 FFFFF         TT   HHHHHH EEEEEE           ║");
            Console.WriteLine("\t║      00   00 FF            TT   HH  HH EE               ║");
            Console.WriteLine("\t║       00000  FF            TT   HH  HH EEEEEE           ║"); 
            Console.WriteLine("\t║                                                         ║");
            Console.WriteLine("\t║      RRRRR   IIIII  NN    NN   GGGG                     ║");
            Console.WriteLine("\t║      RR RR    III   NNNN  NN  GG                        ║");
            Console.WriteLine("\t║      RRRR     III   NN NN NN  GG  GG                    ║");
            Console.WriteLine("\t║      RR RR    III   NN  NNNN  GG   GG                   ║");
            Console.WriteLine("\t║      RR  RR  IIIII  NN   NNN   GGGGGG                   ║"); 
            Console.WriteLine("\t║                                                         ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");
            Console.Write("\tPress Enter to begin:");
            Console.ReadLine();
        }

        public static void Rules()
        {
            Console.Clear();
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║      Player chooses a punch or defense each turn.           ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t║      The computer chooses either a punch or defense at      ║");
            Console.WriteLine("\t║      the same time.                                         ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t║      Choosing the right defense for the attack will         ║");
            Console.WriteLine("\t║      negate all damage.  Only stamina will change.          ║");
            Console.WriteLine("\t║      (Block a Jab, Side Step an Uppercut, Duck a Haymaker)  ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t║      Block is the only move that increases stamina.         ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t║      Side stepping into a Haymaker, or Ducking an Uppercut  ║");
            Console.WriteLine("\t║      takes extra damage.                                    ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t║      The match ends when either the Stamina or the Health   ║");
            Console.WriteLine("\t║      drop below 0.                                          ║");
            Console.WriteLine("\t║                                                             ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════════╝");
            Console.Write("\tPress Enter to begin:");
            Console.ReadLine();
        }

        //General Status Window
        public static void Status(Boxer Player, Boxer AI)
        {
            Console.Clear();
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t║       PLAYER\t\t\t\tOPPONENT        ║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       HEALTH: {Player.Health}\t\t\tHealth: {AI.Health}\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       STAMINA: {Player.Stamina}\t\t\tSTAMINA: {AI.Stamina}\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       STRENGTH: {Player.Strength}\t\t\tSTRENGTH: {AI.Strength}\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       SPEED: {Player.Speed}\t\t\tSPEED: {AI.Speed}\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t╚═══════════════════════════════════════════════════════╝");
        }

        //Printing the menu of options
        public static string Menu()
        {
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t║              CHOOSE A PUCNH OR DEFENSE                ║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t║       [J]AB                           [B]LOCK         ║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t║       [U]PPERCUT                      [S]IDE STEP     ║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t║       [H]AYMAKER                      [D]UCK          ║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t╚═══════════════════════════════════════════════════════╝");
            Console.Write("\tEnter J, U, H, B, S or D:\t");
            string choice = Console.ReadLine();
            choice = Validation.InputCheck(choice);
            return choice;
        }   
            
            
        
        //KO screen for end of match
        public static void Ko(string message)
        {
            Console.Clear();
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║      KKKKK     KKKKK              OOOOOOOOOOOOOO        ║");
            Console.WriteLine("\t║      KKKKK    KKKKK             OOOOOOOOOOOOOOOOOOO     ║");
            Console.WriteLine("\t║      KKKKK   KKKKK              OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK  KKKKK               OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK KKKKK                OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKKKKKK                  OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKKKKKK                  OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK KKKKK                OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK  KKKKK               OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK   KKKKK              OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK    KKKKK             OOOOO         OOOOO     ║");
            Console.WriteLine("\t║      KKKKK     KKKKK            OOOOOOOOOOOOOOOOOOO     ║");
            Console.WriteLine("\t║      KKKKK      KKKKK             OOOOOOOOOOOOOO        ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════╝");
            Console.WriteLine(message);
            Console.ReadLine();
        }


        //Explaining the action to the Player
        public static void Recap(string Choice, string Decision)
        {
            string PlayerChoice = Validation.ChangeChoiceToWord(Choice);
            string OpponentChoice = Validation.ChangeChoiceToWord(Decision);
            Console.Clear();
            Console.WriteLine("\t╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       PLAYER CHOSE {PlayerChoice}\t\t\t\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine($"\t║       OPPONENT CHOSE {OpponentChoice}      \t\t\t║");
            Console.WriteLine("\t║                                                       ║");
            Console.WriteLine("\t╚═══════════════════════════════════════════════════════╝");
            Console.Write("\tPress Enter to Continue");
            Console.ReadLine();
        }
    }
}
