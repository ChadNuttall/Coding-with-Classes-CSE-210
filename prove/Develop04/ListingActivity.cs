using System;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) 
        : base (name, description, duration)
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Random random = new Random();
        string randomPrompt = GetRandomPrompt(random);
        Console.WriteLine($"---{randomPrompt}---");
        Console.WriteLine("You may Begin in");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt(Random random)
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> responses = new List<string>();

        int responseCount = 0;

        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            currentTime = DateTime.Now;
            responseCount ++;
        }

        Console.WriteLine($"You listed {responseCount} items.");
        return responses;
    }
}