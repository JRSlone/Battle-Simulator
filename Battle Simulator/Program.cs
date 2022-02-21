using System;

namespace Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
        Replay:

            Player player1 = new Player("hero", 50);
            Enemy enemy0 = new Enemy("evil", 50);
            Combat CombatSim = new Combat();
            CombatSim.TurnCombat(player1, enemy0);

            Console.WriteLine("Play Again? 'Y' or 'N': ");

            string ReplayOrExit = Console.ReadLine();

            if (ReplayOrExit == "Y")
            {
                goto Replay;
            }
            else
            {
                Ending();
            }

        }
        
        public static void Ending()
        {
            Console.WriteLine("Thanks for Playing!");
        }
    }
}
