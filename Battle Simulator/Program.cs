using System;
using System.Collections.Generic;

namespace Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********BATTLE SIMULATOR***********");

            Console.Write("Name your Character: ");
            String UserName = Console.ReadLine();
            Console.Write("Name your adversary: ");
            String EnemyName = Console.ReadLine();

            Player player1 = new Player(UserName, 50);
            Enemy enemy0 = new Enemy(EnemyName, 50);
            SwordClass sword = new SwordClass("sword", 5);
            AxeClass axe = new AxeClass("axe", 5);
            LanceClass lance = new LanceClass("lance", 5);
            Combat CombatSim = new Combat();

            while (CombatSim.choice != "exit")
            {
                player1.Hp = 50;
                enemy0.enemyHp = 50;
                CombatSim.TurnCombat(player1, enemy0, sword, axe, lance);
               
                Console.WriteLine("To play again press any button, or type 'exit' to Exit: ");
                CombatSim.choice = Console.ReadLine();

            }

            CombatSim.choice = "exit";



        }
    }
}
