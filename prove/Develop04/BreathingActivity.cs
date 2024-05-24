using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) 
        : base (name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int countdown = _duration;

        while (countdown > 0)
        {
            ShowBreathingAnimation();

            countdown -= 10;
        }

        DisplayEndingMessage();
    }
}