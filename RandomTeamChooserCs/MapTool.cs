using System;
using System.Collections.Generic;

namespace RandomTeamChooser
{
    public static class MapTool
    {
        // All existing maps in Valorant
        public static List<string> valorantMaps = new List<string> { "Split", "Bind", "Haven", "Ascent", "Icebox" };

        private static Random rnd = new Random();

        public static void ChooseMap()
        {
            Console.Write("==== MAP TOOL ====\n\n");

            int index = rnd.Next(valorantMaps.Count);
            string result = valorantMaps[index];

            Console.WriteLine(string.Format("Your map is: {0}", result));
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
