using System;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int duration) 
        : base (name, description, duration)
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("\nConnsider the following prompt:");
        Random randomP = new Random();
        string randomPrompt = GetRandomPrompt(randomP);
        Console.WriteLine($"\n---{randomPrompt}---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may Begin in");
        ShowCountDown(5);
        Console.Clear();

        int countdown = _duration;
        Random randomQ = new Random();
        
        while (countdown > 0)
        {
            string rendomQuestion = GetRandomQuestion(randomQ);
            Console.WriteLine(rendomQuestion);
            ShowSpinner(10);
            countdown -= 10;
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt(Random random)
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion(Random random)
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}