using System;

class Program
{
    static void Main(string[] args)
    {

        Address lectureAddress = new Address("123 Main St", "City", "State", "12345");
        Lecture lectureEvent = new Lecture("Exotic Animals", "Explore campus grounds and discover the wild and exotic students and professors in their natural habitat.", "Mar 31, 2025", "2 Hours", lectureAddress, "John Doe", 50);
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.DisplayStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.DisplayFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.DisplayShortDescription());

        Address receptionAddress = new Address("123 Main St", "City", "State", "12345");
        Reception receptionEvent = new Reception("Mr and Mrs", "Obsere the happy couple.", "Jan 01, 3065", "3 Hours", receptionAddress, "receptionrsvp@gmail.com");
        Console.WriteLine("\n---------------------------------------------------------------------------");
        Console.WriteLine("Reception Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.DisplayStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.DisplayFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.DisplayShortDescription());

        Address gatheringAddress = new Address("123 Main St", "City", "State", "12345");
        OutdoorGathering gatheringEvent = new OutdoorGathering("Picnic in the Park", "Enjoy a day outdoors with family and friends", "Dec 25, 1890", "All Day", gatheringAddress, "Cloudy with a chance of Meatballs");
        Console.WriteLine("\n---------------------------------------------------------------------------");
        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(gatheringEvent.DisplayStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(gatheringEvent.DisplayFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(gatheringEvent.DisplayShortDescription());
    }
}