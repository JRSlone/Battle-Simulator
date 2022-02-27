using System;
using System.Collections.Generic;

namespace Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("hero", 50);
            Enemy enemy0 = new Enemy("evil", 50);
            Weapons weapons2 = new Weapons();
            Combat CombatSim = new Combat();

            while (CombatSim.choice != "exit")
            {
                player1.Hp = 50;
                enemy0.enemyHp = 50;
                CombatSim.TurnCombat(player1, enemy0);
               
                Console.WriteLine("To play again press any button, or type 'exit' to Exit: ");
                CombatSim.choice = Console.ReadLine();

            }

            CombatSim.choice = "exit";



        }
    }
}
