using System;
using System.Collections.Generic;

namespace RandomTeamChooser
{
    public static class TeamSideTool
    {
        private static List<string> teamSides = new List<string> { "T", "CT" };

        private static Random rnd = new Random();

        public static void ChooseTeam()
        {
            Console.Write("==== TEAM SIDE CHOOSER TOOL ====\n\n");

            int index = rnd.Next(teamSides.Count);
            string result = teamSides[index];

            Console.WriteLine(string.Format("Your Team: {0}", result));
            Console.WriteLine("\nPress enter to exit...");
            Console.ReadLine();
        }
    }
}
