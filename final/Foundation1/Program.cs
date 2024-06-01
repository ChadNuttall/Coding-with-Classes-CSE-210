using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating videos and adding comments
        Video peacemakersNeeded = new Video("Peacemakers Needed | Russell M. Nelson | April 2023 General Conference", "General Conference of the Church of Jesus Christ", "1144"); // https://www.youtube.com/watch?v=vQghSMOOYz4
        peacemakersNeeded.AddComment("Robert Smith", "Blessed are the peacemakers");
        peacemakersNeeded.AddComment("Aaron Penderson", "This is something that the entire world needs to hear right now.");
        peacemakersNeeded.AddComment("thfatby1187", "Wonderful message of love and peace!!");

        Video bobRoss = new Video("Bob Ross - Campfire (Season 3 Episode 10)", "Bob Ross", "1592");
        bobRoss.AddComment("orianlightcatcher554", "And Bob Ross said \"Let\'s start with cadmium yellow!\" And there was light.");
        bobRoss.AddComment("Gramp1", "Bob ross didn\'t paint masterpieces, he was the masterpiece");
        bobRoss.AddComment("slswain_01", "I watch Bob Ross to fall asleep at night... so peaceful lol");

        videos.Add(peacemakersNeeded);
        videos.Add(bobRoss);

        // Displaying video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine($"Number of Comments: {video.GetCommentsCount()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}