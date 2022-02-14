using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Combat
    {
        public void TurnCombat()
        {
            // needs both players to choose then attacks happen to calculate the bonuses to attack ((FIXED kinda))
            // enemy copies the same move as me at first then just uses that move OVER AND OVER so look into that ((FIXED))
            // look into "break" for exiting while loop? Might do what i need.

            Random random = new Random();

            int playerHp = 50;
            int enemyHP = 50; 
            int enemyChoice = random.Next(0, 2); //this will cover for everything

            int swordAtk = 5;
            int axeAtk = 5;
            int lanceAtk = 5;


            Console.WriteLine("Sword beats Axe, Axe beats Lance, and Lance beats Sword. Granting an added 3 damage when attacking with a favored weapon type");
            while (playerHp > 0 && enemyHP > 0)
            {
                //enemyChoice = random.Next(0, 2); //I dont need this here I guess since its defined above?
                // ----------------Player Turn
                Console.WriteLine("-----Players Turn-----");
                Console.WriteLine("Player HP: " + playerHp + ". Enemy HP: " + enemyHP);
                Console.WriteLine("Enter 's' to attack with Sword, 'a' to attack with Axe, or 'l' to attack with lance.");

                string choice = Console.ReadLine();

                if (choice == "s")
                {
                    Console.WriteLine("You attack with your sword.");
                }
                else if (choice == "a")
                {
                    Console.WriteLine("You attack with your axe.");
                }
                else if (choice == "l")
                {
                    Console.WriteLine("You attack with your lance.");
                }
                else
                {
                    Console.WriteLine("Entry was invalid."); // need this at some point to prevent the turns from advancing and correct it. i don't remember how to do this.
                }

                // ----------------Enemy Turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("-----Enemy Turn-----");
                    Console.WriteLine("Player HP: " + playerHp + ". Enemy HP: " + enemyHP);
                    // int enemyChoice = random.Next(0, 2); //Dont need this here either.

                    if (enemyChoice == 0)
                    {
                        Console.WriteLine("Enemy attacks with their sword.");
                    }
                    else if (enemyChoice == 1)
                    {
                        Console.WriteLine("Enemy attacks with their axe.");
                    }
                    else if (enemyChoice == 2)
                    {
                        Console.WriteLine("Enemy attacks with their lance.");
                    }
                }

                //Sword beats Axe, Axe beats Lance, and Lance beats Sword.
                if (choice == "s" && enemyChoice == 0)
                {
                    playerHp -= swordAtk;
                    enemyHP -= swordAtk;
                }
                else if (choice == "s" && enemyChoice == 1)
                {
                    playerHp -= axeAtk;
                    enemyHP -= swordAtk + 3;
                }
                else if (choice == "s" && enemyChoice == 2)
                {
                    playerHp -= lanceAtk + 3;
                    enemyHP -= swordAtk;
                }
                else if (choice == "a" && enemyChoice == 0)
                {
                    playerHp -= swordAtk + 3;
                    enemyHP -= axeAtk;
                }
                else if (choice == "a" && enemyChoice == 1)
                {
                    playerHp -= axeAtk;
                    enemyHP -= axeAtk;
                }
                else if (choice == "a" && enemyChoice == 2)
                {
                    playerHp -= lanceAtk;
                    enemyHP -= axeAtk + 3;
                }
                else if (choice == "l" && enemyChoice == 0)
                {
                    playerHp -= swordAtk;
                    enemyHP -= lanceAtk + 3;
                }
                else if (choice == "l" && enemyChoice == 1)
                {
                    playerHp -= axeAtk + 3;
                    enemyHP -= lanceAtk;
                }
                else if (choice == "l" && enemyChoice == 2)
                {
                    playerHp -= lanceAtk;
                    enemyHP -= lanceAtk;
                }
            }

            if (playerHp <= 0 && enemyHP > 0)
            {
                Console.WriteLine("You Lose");
            }
            else if (playerHp > 0 && enemyHP <= 0)
            {
                Console.WriteLine("Congrats You Win!!");
            }
            else
            {
                Console.WriteLine("You Tied");
            }
            Console.ReadKey();
        }
    }
}
