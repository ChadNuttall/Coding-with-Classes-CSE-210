using System;
using System.IO;

// -- Showing Creativity and Exceeding Requirements -- //
// Save other information in the journal entry. The name of writer.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
        
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nThe Journal Program");
            Console.WriteLine("Please enter one:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\nWhat is your name? ");
                    string name = Console.ReadLine();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.WriteLine("> ");
                    string response = Console.ReadLine();
                    journal.AddEntry(name, prompt, response);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("\nEnter the filename to save:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case "4":
                    Console.WriteLine("\nEnter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case "5":
                    Console.WriteLine("\nCatch you next time!");
                    quit = true;
                    break;
                default:
                    Console.WriteLine("\nError. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}