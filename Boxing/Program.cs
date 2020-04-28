using System;


namespace Boxing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Boxer Player = new Boxer();
            Boxer Computer = new Boxer();
            string message;
            DisplayMessages.Title();
            DisplayMessages.Rules();

            do
            {
                DisplayMessages.Status(Player, Computer);
                Player.Choice = DisplayMessages.Menu();
                Computer.Choice = AI.Decision();
                DisplayMessages.Recap(Player.Choice, Computer.Choice);
                GamePlay.Resolve(Player, Computer);
                GamePlay.Resolve(Computer, Player);            
            } while ((Player.Health > 0) && (Player.Stamina > 0) && 
                     (Computer.Health > 0) && (Computer.Stamina > 0));

            message = GamePlay.CheckForWinner(Player, Computer);
            DisplayMessages.Ko(message);
            
        }
    }
}
