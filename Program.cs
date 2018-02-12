using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run intro
            GetAppInfo();

            // Run Greeting
            GreetUser();

            while (true)
            {

                Random random = new Random();
     
                int correctNumber = random.Next(1, 11);
                int guess = 0;
                
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Check for valid input
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Not a valid input.  Enter a number between 1 and 10.");

                        // Restart while loop
                        continue;
                    }

                    // Check if guess is correct
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "you are CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer != "N")
                {
                    continue;
                } else
                {
                    return;
                }
            }

        }

        // Get and display app info
        private static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Xavier Trinidad (Original Brad Traversy)";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        private static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        private static void startGame()
        {

        }

        // Print color message
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user the wrong number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
