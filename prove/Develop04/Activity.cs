using System;

class Activity
{
    public string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your sesion?  ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        
        Thread.Sleep(3000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerAnimation.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowBreathingAnimation()
    {
        string breathIn = "BREATH IN";
        string breathOut = "BREATH OUT...";

        int breathInDuration = 2500;
        int breathOutDuration = 5500;

        // Breathing out will appear slower than Breathing in making you feel more relaxed
        int breathInSpeed = breathInDuration / breathIn.Length;
        int breathOutSpeed = breathOutDuration / breathOut.Length;

        foreach (char c in breathIn)
        {
            Console.Write(c);
            Thread.Sleep(breathInSpeed);
        }

        Thread.Sleep(1000);
        Console.Clear();

        foreach (char c in breathOut)
        {
            Console.Write(c);
            Thread.Sleep(breathOutSpeed);
        }

        Thread.Sleep(1000);
        Console.Clear();
    }
}