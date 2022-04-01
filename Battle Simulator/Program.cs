using System;

namespace Battle_Simulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Combat CombatSim = new Combat();
            string UserName = "";
            string EnemyName = "";
            var userEntry = "";

            Restart:
            Console.WriteLine("***********BATTLE SIMULATOR***********");

            Console.WriteLine("Would you like to load a profile?");
            Console.WriteLine("If this is your first game type 'no'");
            Console.WriteLine("Enter 'yes' to load a profile or 'no' to start a new game.");
            string loadProfile = Console.ReadLine();

            if (loadProfile == "yes")
            {
                while (UserName == "" && EnemyName == "" && userEntry != "exit")
                {


                    Console.WriteLine("Please enter your saved character name");
                    string userProfile = Console.ReadLine();
                    string[] profile = readProfile(userProfile, "playerProfile.txt", 1);
                    if (profile != null && profile[0] != "")
                    {
                        UserName = profile[0];
                        EnemyName = profile[2];
                        CombatSim = new Combat(int.Parse(profile[1]), int.Parse(profile[3]));
                        Console.WriteLine("");
                        Console.WriteLine("---Press 'Enter' to load the saved profile.---");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid Entry, press Enter to try again");
                        Console.WriteLine("or type 'exit' to end to application");
                        Console.WriteLine("");
                        userEntry = Console.ReadLine();
                    }
                }
            }
            else if (loadProfile == "no")
            {
                Console.Write("Name your Character: ");
                UserName = Console.ReadLine();
                Console.Write("Name your adversary: ");
                EnemyName = Console.ReadLine();
                CombatSim = new Combat();
            }
            else
            {
                Console.WriteLine("Invalid Entry, Restarting Application");
                Console.WriteLine("");
                Console.WriteLine("");
                goto Restart;
            }

            static string[] readProfile(string searchTerm, string filepath, int positionOfSearchTerm)
            {
                positionOfSearchTerm--;
                string[] profileNotFound = { "Profile not found" };

                {
                    string[] lines = System.IO.File.ReadAllLines(@filepath);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (profileMatches(searchTerm, fields, positionOfSearchTerm))
                        {
                            Console.WriteLine("---Profile found---");
                            return fields;
                        }
                    }
                    return null;
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

            Player player1 = new Player(UserName, 50);
            Enemy enemy0 = new Enemy(EnemyName, 50);
            SwordClass sword = new SwordClass("sword", 5);
            AxeClass axe = new AxeClass("axe", 5);
            LanceClass lance = new LanceClass("lance", 5);

            while (CombatSim.choice != "exit" && UserName != "")
            {
                player1.Hp = 50;
                enemy0.enemyHp = 50;
                CombatSim.TurnCombat(player1, enemy0, sword, axe, lance);
               
                Console.WriteLine("To play again press Enter, or type 'exit' then Enter to Exit the Program: ");
                Console.WriteLine("Typing 'exit' will save your profile, this can be loaded when starting the program again.");
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
                        file.WriteLine($"{playerID},{playerWin},{enemyID},{enemyWin}");
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