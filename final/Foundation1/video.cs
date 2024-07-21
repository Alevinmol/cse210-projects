using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length; //in seconds
    public List<Comment> _comments = new List<Comment>(); // comments

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name} commented: {comment._commentText}.");
        }
    }
}