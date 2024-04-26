using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number?");
        //string userInput = Console.ReadLine(); 
        //int magicNumber = int.Parse(userInput);
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That is the magic number!");
            }
        }
    }
}