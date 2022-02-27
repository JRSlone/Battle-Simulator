using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Combat
    {
        public string choice;
        public void TurnCombat(Player player1, Enemy enemy0)//, Weapons weapons2)
        {
            // add like a win and lose counter.
            // profile for character.
            // unit test
            // try to figure out a save feature?????????? *json*, text or log file
            // Console.clear(); to clear the console app instead of keeping all the history of the battles

            Random random = new Random();

            int enemyChoice;

            // replace following ints with a new weapon class
            int swordAtk = 5;
            int axeAtk = 5;
            int lanceAtk = 5;

            Console.WriteLine("Sword beats Axe, Axe beats Lance, and Lance beats Sword. Granting an added 3 damage when attacking with a favored weapon type");
            while (player1.Hp > 0 && enemy0.enemyHp > 0)
            {
                var variable1 = "Joe"; //set so user can type
                enemyChoice = random.Next(0, 3);
                // ----------------Player Turn------------------------
                Console.WriteLine("-----Players Turn-----");
                Console.WriteLine("Player HP: " + player1.Hp + ". Enemy HP: " + enemy0.enemyHp);
                Console.WriteLine("Enter 's' to attack with Sword, 'a' to attack with Axe, or 'l' to attack with lance.");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "s":
                        Console.WriteLine($"{variable1} attack with your sword."); //example of how to fill in the user name
                        break;
                    case "a":
                        Console.WriteLine("You attack with your axe.");
                        break;
                    case "l":
                        Console.WriteLine("You attack with your lance.");
                        break;
                    default:
                        Console.WriteLine("Entry was invalid.");
                        break;

                }

                // ----------------Enemy Turn------------------
                if (enemy0.enemyHp > 0)
                {
                    Console.WriteLine("-----Enemy Turn-----");
                    Console.WriteLine("Player HP: " + player1.Hp + ". Enemy HP: " + enemy0.enemyHp);
                    // int enemyChoice = random.Next(0, 2); //Dont need this here either.

                    switch(enemyChoice)
                    {
                        case 0:
                            Console.WriteLine("Enemy attacks with their sword.");
                            break;
                        case 1:
                            Console.WriteLine("Enemy attacks with their axe.");
                            break;
                        case 2:
                            Console.WriteLine("Enemy attacks with their lance.");
                            break;
                    }

                }

                // Sword beats Axe, Axe beats Lance, and Lance beats Sword. Maybe add something more interesting for combat then just Rock Paper Scissors ?
                // Look at switch statement to replace if/else if ((doesnt work))
                // class or list to define what happens when for example a sword attacks a sword... (dictionary)

                if (choice == "s" && enemyChoice == 0)
                {
                    player1.Hp -= swordAtk;
                    enemy0.enemyHp -= swordAtk;
                }
                else if (choice == "s" && enemyChoice == 1)
                {
                    player1.Hp -= axeAtk;
                    enemy0.enemyHp -= swordAtk + 3;
                }
                else if (choice == "s" && enemyChoice == 2)
                {
                    player1.Hp -= lanceAtk + 3;
                    enemy0.enemyHp -= swordAtk;
                }
                else if (choice == "a" && enemyChoice == 0)
                {
                    player1.Hp -= swordAtk + 3;
                    enemy0.enemyHp -= axeAtk;
                }
                else if (choice == "a" && enemyChoice == 1)
                {
                    player1.Hp -= axeAtk;
                    enemy0.enemyHp -= axeAtk;
                }
                else if (choice == "a" && enemyChoice == 2)
                {
                    player1.Hp -= lanceAtk;
                    enemy0.enemyHp -= axeAtk + 3;
                }
                else if (choice == "l" && enemyChoice == 0)
                {
                    player1.Hp -= swordAtk;
                    enemy0.enemyHp -= lanceAtk + 3;
                }
                else if (choice == "l" && enemyChoice == 1)
                {
                    player1.Hp -= axeAtk + 3;
                    enemy0.enemyHp -= lanceAtk;
                }
                else if (choice == "l" && enemyChoice == 2)
                {
                    player1.Hp -= lanceAtk;
                    enemy0.enemyHp -= lanceAtk;
                }
            }

            if (player1.Hp <= 0 && enemy0.enemyHp > 0)
            {
                Console.WriteLine("You Lose");
            }
            else if (player1.Hp > 0 && enemy0.enemyHp <= 0)
            {
                Console.WriteLine("Congrats You Win!!");
            }
            else
            {
                Console.WriteLine("You Tied"); //have no concept whether i can tie right now so look into that, do attacks occur at the same time?? i believe so???????????
            }
            Console.ReadKey();
        }
    }
}
