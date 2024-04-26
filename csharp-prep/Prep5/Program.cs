using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);

        DisplayResults(userName,squareNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());

            return favoriteNumber;
        }
        static int SquareNumber(int favoriteNumber)
        {
            int squareNumber = favoriteNumber * favoriteNumber;
            
            return squareNumber;
        }
        static void DisplayResults(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squareNumber}");
        }
    }
}