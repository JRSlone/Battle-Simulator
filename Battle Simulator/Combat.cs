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
            Random random = new Random();
            int enemyChoice;

            //int winCount = 0; NOT WORKING ATM
            //int enemyWinCount = 0;
            //use list here to reference each weapons. class for each weapon.

            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to Battle Simulator!");
            Console.WriteLine($"Reduce {enemy0.enemyName}'s HP to zero!");
            Console.WriteLine("Sword > Axe");
            Console.WriteLine("Axe > Lance");
            Console.WriteLine("Lance > Sword");
            Console.WriteLine("");
            //Console.WriteLine("");
            while (player1.Hp > 0 && enemy0.enemyHp > 0)
            {
                enemyChoice = random.Next(0, 3);

                //Console.WriteLine($"{player1.Name}'s Wins: {winCount}");
                //Console.WriteLine($"{enemy0.enemyName}'s Wins: {enemyWinCount}");
                // ----------------Player Turn------------------------
                Console.WriteLine($"-----{player1.Name}'s Turn-----");
                Console.WriteLine($"{player1.Name} HP: {player1.Hp}");
                Console.WriteLine($"{enemy0.enemyName} HP: {enemy0.enemyHp}");
                Console.WriteLine("___________________________________");
                Console.WriteLine("Type 's' to attack with your Sword");
                Console.WriteLine("Type 'a' to attack with your Axe");
                Console.WriteLine("Type 'l' to attack with your Lance");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "s":
                        Console.WriteLine($"{player1.Name} attacks with their {sword.weaponName}.");
                        break;
                    case "a":
                        Console.WriteLine($"{player1.Name} attacks with their {axe.weaponName}.");
                        break;
                    case "l":
                        Console.WriteLine($"{player1.Name} attacks with their {lance.weaponName}.");
                        break;
                    default:
                        Console.WriteLine("Entry was invalid.");
                        Console.WriteLine("This round will now start over.");
                        break;

                }

                // ----------------Enemy Turn------------------
                if (enemy0.enemyHp > 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"-----{enemy0.enemyName}'s Turn-----");
                    Console.WriteLine($"{player1.Name} HP: {player1.Hp}");
                    Console.WriteLine($"{enemy0.enemyName} HP: {enemy0.enemyHp}");

                    switch(enemyChoice)
                    {
                        case 0:
                            Console.WriteLine($"{enemy0.enemyName} attacks with their sword.");
                            break;
                        case 1:
                            Console.WriteLine($"{enemy0.enemyName} attacks with their axe.");
                            break;
                        case 2:
                            Console.WriteLine($"{enemy0.enemyName} attacks with their lance.");
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
                Console.WriteLine($"{player1.Name} Loses");
                //enemyWinCount += 1;
            }
            else if (player1.Hp > 0 && enemy0.enemyHp <= 0)
            {
                Console.WriteLine($"Congrats you defeated {enemy0.enemyName}!");
                //winCount += 1;
            }
            else
            {
                Console.WriteLine($"{player1.Name} and {enemy0.enemyName} Tied");
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
