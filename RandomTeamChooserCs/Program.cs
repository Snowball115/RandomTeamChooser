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
                Console.Write("\n1. Map chooser\n2. Random team generator\n3. Exit program\n\n");
                Console.Write("Your number: ");

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
