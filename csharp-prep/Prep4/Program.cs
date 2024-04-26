using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int enterNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (enterNumber != 0)
        {
            Console.WriteLine("Enter number: ");
            enterNumber = int.Parse(Console.ReadLine());

            if (enterNumber != 0){
                numbers.Add(enterNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;

        int max = -1;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}