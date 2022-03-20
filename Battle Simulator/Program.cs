using System;
using System.Collections.Generic;

namespace Battle_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********BATTLE SIMULATOR***********");

            {
                Console.WriteLine(string.Join("", readProfile("Joetest", "playerProfile.txt", 1)));
                Console.ReadLine();
            }


            static string[] readProfile(string searchTerm, string filepath, int positionOfSearchTerm)
            {
                positionOfSearchTerm--;
                string[] profileNotFound = { "Profile not found" };

                try
                {
                    string[] lines = System.IO.File.ReadAllLines(@filepath);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (profileMatches(searchTerm, fields, positionOfSearchTerm))
                        {
                            Console.WriteLine("Profile found");
                            return fields;
                        }
                    }

                    return profileNotFound;


                }

                catch(Exception ex)
                {
                    Console.WriteLine("There was an error");
                    return profileNotFound;
                    throw new ApplicationException("Thats an error:", ex);
                }
            }

            static bool profileMatches(string searchTerm, string[] record, int positionOfSearchTerm)
            {
                if (record[positionOfSearchTerm].Equals(searchTerm))
                {
                    return true;
                }
                return false;
            }


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

            addProfile(UserName, EnemyName, CombatSim.winCount, CombatSim.enemyWinCount, "playerProfile.txt");

            static void addProfile(string playerID, string enemyID, int playerWin, int enemyWin, string filepath)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                    {
                        file.WriteLine($"{playerID}, {playerWin}, {enemyID}, {enemyWin}");
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Thats an error:", ex);
                }
            }




        }
    }
}

//try to load player profile with wins and losses
//prompt user for wanting to load OR create a new game