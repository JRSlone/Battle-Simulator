using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Simulator
{
    class Combat
    {
        public void TurnCombat(Player player1, Enemy enemy0)
        {
            // needs both players to choose then attacks happen to calculate the bonuses to attack ((FIXED kinda))
            // enemy copies the same move as me at first then just uses that move OVER AND OVER so look into that ((FIXED?))
            // look into "break" for exiting while loop? Might do what i need. ((used goto instead))
            // add a play again /exit stuff to fufill ((Master Loop)) ((Complete, ask if other ways instead of goto))
            // add like a win and lose counter.
            // profile for character.
            // unit test
            // try to figure out a save feature?????????? *json*, text or log file
            // Console.clear(); to clear the console app instead of keeping all the history of the battles

            Random random = new Random();

            //int player1.Hp = 50; //no longer needed, replaced with Player class
            //int enemy0.enemyHp = 50; //no longer needed, replaced with Enemy class
            int enemyChoice = random.Next(0, 2); //this will cover for everything dont think i need it in the while loop..

            int swordAtk = 5;
            int axeAtk = 5;
            int lanceAtk = 5;

            Console.WriteLine("Sword beats Axe, Axe beats Lance, and Lance beats Sword. Granting an added 3 damage when attacking with a favored weapon type");
            while (player1.Hp > 0 && enemy0.enemyHp > 0)
            {
                enemyChoice = random.Next(0, 2); //I dont need this here I guess since its defined above?
                // ----------------Player Turn
                Console.WriteLine("-----Players Turn-----");
                Console.WriteLine("Player HP: " + player1.Hp + ". Enemy HP: " + enemy0.enemyHp);
                Console.WriteLine("Enter 's' to attack with Sword, 'a' to attack with Axe, or 'l' to attack with lance.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "s":
                        Console.WriteLine("You attack with your sword.");
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

                //-------------------------old if statement for player actions.
                //if (choice == "s") //OPTING TO USE SWITCH STATEMENT ABOVE INSTEAD TO MAKE CODE A LITTLE CLEANER.
                //{
                //    Console.WriteLine("You attack with your sword.");
                //}
                //else if (choice == "a")
                //{
                //    Console.WriteLine("You attack with your axe.");
                //}
                //else if (choice == "l")
                //{
                //    Console.WriteLine("You attack with your lance.");
                //}
                //else
                //{
                //    Console.WriteLine("Entry was invalid."); // need this at some point to prevent the turns from advancing and correct it. i don't remember how to do this.
                //}

                // ----------------Enemy Turn
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

                    // ---------------------------Old if statement for enemy choices
                    //if (enemyChoice == 0) //OPTING TO USE SWITCH STATEMENT ABOVE INSTEAD TO MAKE CODE A LITTLE CLEANER.
                    //{
                    //    Console.WriteLine("Enemy attacks with their sword.");
                    //}
                    //else if (enemyChoice == 1)
                    //{
                    //    Console.WriteLine("Enemy attacks with their axe.");
                    //}
                    //else if (enemyChoice == 2)
                    //{
                    //    Console.WriteLine("Enemy attacks with their lance.");
                    //}
                }

                //switch (choice, enemyChoice.ToString()) //DOESNT WORK ask about this in class.
                //{
                //    case "s", "0":   
                //        break;
                //}

                //Sword beats Axe, Axe beats Lance, and Lance beats Sword. Maybe add something more interesting for combat then just Rock Paper Scissors ?
                //Look at switch statement to replace if/else if ((doesnt work))

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
