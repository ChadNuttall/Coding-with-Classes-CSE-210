using System;

// -- Showing Creativity and Exceeding Requirements -- //
// Adding more meaningful animations for the breathing

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Activity Program.");

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Strart Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                    reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
                    listingActivity.Run();
                    break;
                case "4":
                    quit = true;
                    break;
            }
        }
    }
}