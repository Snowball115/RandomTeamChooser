using System;

namespace RandomTeamChooser
{
    class Program
    {
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("==== Choose Tool ====");
            Console.Write("\n1. Map chooser\n2. Random team generator\n\n");
            Console.Write("Your number: ");

            while (isRunning)
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        MapTool.ChooseMap();
                        isRunning = false;
                        break;

                    case "2":
                        Console.Clear();
                        TeamTool.GenerateTeams();
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("No valid input detected. Please choose again.\n");
                        Console.Write("Your number: ");
                        break;
                }
            } 
        }
    }
}
