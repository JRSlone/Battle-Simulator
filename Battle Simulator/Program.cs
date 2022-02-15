using System;

namespace Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
        Replay:

            Combat CombatSim = new Combat();
            CombatSim.TurnCombat();

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
