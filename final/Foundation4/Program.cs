using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running("Jan 01 2024", 15, 2.5);
        activities.Add(run1);

        Cycling cycle1 = new Cycling("Jan 02 2024", 30, 8);
        activities.Add(cycle1);

        Swimming swim1 = new Swimming("Jan 03 2024", 30, 25);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine(activity.GetSummary());
        }
    }
}