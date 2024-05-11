using System;

// -- Showing Creativity and Exceeding Requirements -- //
// Program works with a library of scriptures for the user to choose from rather than a single one
// Words to hide are randomly select from only those words that are not already hidden

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Scripture Memorizer Program.");

        bool quit = false;
        Reference reference = null;
        Scripture scripture = null;

        while (!quit)
        {
            Console.WriteLine("\nScripture Memorizer");
            Console.WriteLine("Please Enter what scripture you would like to memorize.");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.WriteLine("Type 'quit' to finish");

            Console.WriteLine("\nWhat would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Set the scripture to John 3:16
                    reference = new Reference("John", 3, 16);
                    scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
                    break;
                case "2":
                    // Set the scripture to Proverbs 3:5-6
                    reference = new Reference("Proverbs", 3, 5, 6);
                    scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
                    break;
                case "quit":
                    // Quit the program
                    quit = true;
                    break;
            }

            // If scripture is set and user hasn't chosen to quit
            if (!quit && scripture != null)
            {
                // Clear the console and display the scripture
                Console.Clear();
                DisplayScripture(reference, scripture);

                // Continue hiding words until user quits or all words are hidden
                Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
                string userInput = Console.ReadLine();
                while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
                {
                    scripture.HideRandomWords(2);

                    Console.Clear();
                    DisplayScripture(reference, scripture);

                    Console.WriteLine("Press Enter to continue or type 'quit' to finish: ");
                    userInput = Console.ReadLine();
                }
            }
        }
    }

    static void DisplayScripture(Reference reference, Scripture scripture)
    {
        Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
    }
}