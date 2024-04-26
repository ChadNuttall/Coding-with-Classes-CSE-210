using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Grade Percentage: ");
        string userGivenGrade = Console.ReadLine();

        int gradePercenatge = int.Parse(userGivenGrade);
        string letterGrade = "";

        if (gradePercenatge >= 90){
            letterGrade = "A";
        }
        else if (gradePercenatge >= 80 && gradePercenatge < 90){
            letterGrade = "B";
        }
        else if (gradePercenatge >= 70 && gradePercenatge < 80){
            letterGrade = "C";
        }
        else if (gradePercenatge >= 60 && gradePercenatge < 70){
            letterGrade = "D";
        }
        else if (gradePercenatge < 60){
            letterGrade = "F";
        }
        else{
            Console.WriteLine("Error");
        }

        Console.WriteLine ($"Your Letter Grade is {letterGrade}.");

        if (gradePercenatge >= 70){
            Console.WriteLine("Congrats you Passed!");
        }
        else{
            Console.WriteLine("Better Luck next time.");
        }
    }
}