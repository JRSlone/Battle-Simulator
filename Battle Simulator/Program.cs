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

            Console.WriteLine("***********BATTLE SIMULATOR***********");

            Console.WriteLine("Would you like to load a profile?");
            Console.WriteLine("Enter 'yes' to load a profile or 'no' to start a new game.");
            string loadProfile = Console.ReadLine();

            if (loadProfile == "yes")
            {
                Console.WriteLine("Please enter your saved character name");
                string userProfile = Console.ReadLine();
                string[] profile = readProfile(userProfile, "playerProfile.txt", 1);
                UserName = profile[0];
                Console.WriteLine("---Press 'Enter' to load the saved profile.---");
                EnemyName = profile[2];
                Console.ReadLine();
                CombatSim = new Combat(int.Parse(profile[1]), int.Parse(profile[3]));
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

            if (loadProfile == "no")
            {
                Console.Write("Name your Character: ");
                UserName = Console.ReadLine();
                Console.Write("Name your adversary: ");
                EnemyName = Console.ReadLine();
                CombatSim = new Combat();
            }

            Player player1 = new Player(UserName, 50);
            Enemy enemy0 = new Enemy(EnemyName, 50);
            SwordClass sword = new SwordClass("sword", 5);
            AxeClass axe = new AxeClass("axe", 5);
            LanceClass lance = new LanceClass("lance", 5);

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