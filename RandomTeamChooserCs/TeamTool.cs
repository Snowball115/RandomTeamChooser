using System;
using System.Collections.Generic;

namespace RandomTeamChooser
{
    public static class TeamTool
    {
        private static List<string> activePlayers = new List<string>();
        private static Random rnd = new Random();

        private static float teamsCount = 0;
        private static float playersCount = 0;
        private static float playersPerTeamCount = 0;

        /*=================================
         *      MAIN PROCESS
         *=================================*/
        public static void GenerateTeams()
        {
            Console.Write("==== TEAM TOOL ====\n\n");

            CountTeams();

            CountPlayers();

            // Calculate player count equally for all teams
            playersPerTeamCount = (playersCount / teamsCount);

            Console.Write("\n");

            // If number is not a whole number, adjust the index count of list, because we can't add a "half" player to the team
            // HACK: Just count the length of string, if bigger than 1, its not a whole number (decimal). Basically adding a invisible player to make it work
            string stringToCheck = playersPerTeamCount.ToString();
            if (stringToCheck.Length > 1)
            {
                double newPlayerCount = Convert.ToDouble(playersPerTeamCount);
                newPlayerCount = Math.Round(playersPerTeamCount, 0, MidpointRounding.AwayFromZero);
                playersPerTeamCount = Convert.ToSingle(newPlayerCount);

                activePlayers.Add("");
            }

            // Save all active players
            for (int i = 0; i < playersCount; i++)
            {
                Console.Write(string.Format("Player {0}: ", i + 1));
                activePlayers.Add(Console.ReadLine());
            }

            Console.Write("\n");

            // Randomize player order
            //activePlayers = activePlayers.OrderBy(x => rnd.Next()).ToList();
            activePlayers = ShuffleList(activePlayers);

            for (int i = 0; i < teamsCount; i++)
            {
                Console.WriteLine(string.Format("==== TEAM {0} ====", i + 1));

                // Create array for each team (faster than list)
                string[] team = new string[Convert.ToInt32(playersPerTeamCount)];

                // Get players from shuffled list and put them in the current team
                for (int j = 0; j < playersPerTeamCount; j++)
                {
                    string player = GetPlayerFromList(activePlayers);

                    team[j] = player;

                    // Write the invisible player in the same line to hide the space between players
                    if (team[j] == "") Console.Write(team[j]);
                    else Console.WriteLine(team[j]);
                }
            }

            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }


        /*=================================
         *      HELPER FUNCTIONS
         *=================================*/

        // Set team count
        public static void CountTeams()
        {
            Console.Write("How many teams are playing? ");
            string teamsCountString = Console.ReadLine();
            if (!float.TryParse(teamsCountString, out teamsCount))
            {
                // Error handling
                Console.WriteLine("\nPlease type in a whole number...\n");
                CountTeams();
                return;
            }
            teamsCount = Convert.ToSingle(teamsCountString);
        }

        // Set player count
        public static void CountPlayers()
        {
            Console.Write("How many players are online? ");
            string playersCountString = Console.ReadLine();
            if (!float.TryParse(playersCountString, out playersCount))
            {
                // Error handling
                Console.WriteLine("\nPlease type in a whole number...\n");
                CountPlayers();
                return;
            }
            playersCount = Convert.ToSingle(playersCountString);
        }

        // Randomize the order of all elements in a list
        public static List<T> ShuffleList<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int index = rnd.Next(0, i);
                T value = list[index];
                list[index] = list[i];
                list[i] = value;
            }

            return list;
        }

        // Draw first player from the list and remove him
        public static string GetPlayerFromList(List<string> playerList)
        {
            string player = playerList[0];
            playerList.RemoveAt(0);
            return player;
        }
    }
}