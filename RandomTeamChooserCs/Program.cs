using System;

namespace RandomTeamChooser
{
    class Program
    {
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            while (isRunning)
            {
                Console.WriteLine("==== Choose Tool ====");
                Console.WriteLine("\n1. Map chooser\n2. Random team generator\n3. Team side chooser\n4. Exit program\n\n");
                Console.Write("Your choice: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        MapTool.ChooseMap();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        TeamTool.GenerateTeams();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        TeamSideTool.ChooseTeam();
                        Console.Clear();
                        break;

                    case "4":
                        isRunning = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("No valid input detected. Please choose again.\n");
                        break;
                }
            } 
        }
    }
}
