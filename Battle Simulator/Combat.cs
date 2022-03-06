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
        public void TurnCombat(Player player1, Enemy enemy0, SwordClass sword, AxeClass axe, LanceClass lance)
        {
            Console.Write("Name your Character: ");
            String UserName = Console.ReadLine();
            Console.Write("Name your adversary: ");
            String EnemyName = Console.ReadLine();

            Random random = new Random();
            int enemyChoice;

            //use list here to reference each weapons. class for each weapon.

            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to Battle Simulator!");
            Console.WriteLine($"Reduce {EnemyName}'s HP to zero!");
            Console.WriteLine("Sword > Axe");
            Console.WriteLine("Axe > Lance");
            Console.WriteLine("Lance > Sword");
            Console.WriteLine("");
            while (player1.Hp > 0 && enemy0.enemyHp > 0)
            {
                enemyChoice = random.Next(0, 3);
                // ----------------Player Turn------------------------
                Console.WriteLine($"-----{UserName}'s Turn-----");
                Console.WriteLine($"{UserName} HP: {player1.Hp}");
                Console.WriteLine($"{EnemyName} HP: {enemy0.enemyHp}");
                Console.WriteLine("___________________________________");
                Console.WriteLine("Type 's' to attack with your Sword");
                Console.WriteLine("Type 'a' to attack with your Axe");
                Console.WriteLine("Type 'l' to attack with your Lance");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "s":
                        Console.WriteLine($"{UserName} attacks with their {sword.weaponName}.");
                        break;
                    case "a":
                        Console.WriteLine($"{UserName} attacks with their {axe.weaponName}.");
                        break;
                    case "l":
                        Console.WriteLine($"{UserName} attacks with their {lance.weaponName}.");
                        break;
                    default:
                        Console.WriteLine("Entry was invalid.");
                        break;

                }

                // ----------------Enemy Turn------------------
                if (enemy0.enemyHp > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"-----{EnemyName}'s Turn-----");
                    Console.WriteLine($"{UserName} HP: {player1.Hp}");
                    Console.WriteLine($"{EnemyName} HP: {enemy0.enemyHp}");

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

                if (choice == "s" && enemyChoice == 0)
                {
                    player1.Hp -= sword.weaponDmg;
                    enemy0.enemyHp -= sword.weaponDmg;
                }
                else if (choice == "s" && enemyChoice == 1)
                {
                    player1.Hp -= axe.weaponDmg;
                    enemy0.enemyHp -= sword.weaponDmg + 5;
                }
                else if (choice == "s" && enemyChoice == 2)
                {
                    player1.Hp -= lance.weaponDmg + 5;
                    enemy0.enemyHp -= sword.weaponDmg;
                }
                else if (choice == "a" && enemyChoice == 0)
                {
                    player1.Hp -= sword.weaponDmg + 5;
                    enemy0.enemyHp -= axe.weaponDmg;
                }
                else if (choice == "a" && enemyChoice == 1)
                {
                    player1.Hp -= axe.weaponDmg;
                    enemy0.enemyHp -= axe.weaponDmg;
                }
                else if (choice == "a" && enemyChoice == 2)
                {
                    player1.Hp -= lance.weaponDmg;
                    enemy0.enemyHp -= axe.weaponDmg + 5;
                }
                else if (choice == "l" && enemyChoice == 0)
                {
                    player1.Hp -= sword.weaponDmg;
                    enemy0.enemyHp -= lance.weaponDmg + 5;
                }
                else if (choice == "l" && enemyChoice == 1)
                {
                    player1.Hp -= axe.weaponDmg + 5;
                    enemy0.enemyHp -= lance.weaponDmg;
                }
                else if (choice == "l" && enemyChoice == 2)
                {
                    player1.Hp -= lance.weaponDmg;
                    enemy0.enemyHp -= lance.weaponDmg;
                }

                Console.WriteLine("");
                Console.WriteLine("");
            }

            if (player1.Hp <= 0 && enemy0.enemyHp > 0)
            {
                Console.WriteLine($"{UserName} Loses");
            }
            else if (player1.Hp > 0 && enemy0.enemyHp <= 0)
            {
                Console.WriteLine($"Congrats you defeated {EnemyName}!");
            }
            else
            {
                Console.WriteLine($"{UserName} and {EnemyName} Tied");
            }
            Console.ReadKey();
        }
    }
}

// add like a win and lose counter.
// profile for character.
// unit test
// try to figure out a save feature?????????? *json*, text or log file
// Console.clear(); to clear the console app instead of keeping all the history of the battles
// Sword beats Axe, Axe beats Lance, and Lance beats Sword. Maybe add something more interesting for combat then just Rock Paper Scissors ?
// class or list to define what happens when for example a sword attacks a sword... (dictionary)
