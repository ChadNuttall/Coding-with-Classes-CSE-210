public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string name, string commentText)
    {
        _comments.Add(new Comment(name, commentText));
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
    }

    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}

