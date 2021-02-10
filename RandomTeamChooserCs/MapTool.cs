using System;
using System.Collections.Generic;

namespace RandomTeamChooser
{
    public static class MapTool
    {
        // All existing maps in Valorant
        private static List<string> valorantMaps = new List<string> { "Split", "Bind", "Haven", "Ascent", "Icebox" };

        // All existing maps in MW2
        private static List<string> mw2Maps = new List<string> { "Afghan", "Derail", "Estate", "Favela", "Highrise", "Invasion", "Karachi", "Quarry", "Rundown", "Scrapyard", "Skidrow", "Sub Base", "Terminal", "Underpass", "Wasteland" };

        private static Random rnd = new Random();

        public static void ChooseMap()
        {
            Console.Write("==== MAP TOOL ====\n\n");
            Console.WriteLine("1. Valorant\n2. CoD MW2\n");
            Console.Write("Your choice: ");

            List<string> gameMaps = chooseGameMaps(Console.ReadLine());

            int index = rnd.Next(gameMaps.Count);
            string result = gameMaps[index];

            Console.WriteLine(string.Format("\nYour map is: {0}\n", result));
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        private static List<string> chooseGameMaps(string index)
        {
            List<string> tmpList = new List<string>();

            switch (index)
            {
                case "1":
                    tmpList = valorantMaps;
                    break;

                case "2":
                    tmpList = mw2Maps;
                    break;

                default:
                    Console.WriteLine("No valid input detected. Shutdown.");
                    break;
            }

            return tmpList;
        }
    }
}
