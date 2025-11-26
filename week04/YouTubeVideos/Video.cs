using System;
using System.Collections;

public class Video
{
    private string _titleV;
    private string _author;
    private int _timeVideo;
    private List<Comment> _comments = new List<Comment>();

    // Constructors
    public Video(string title, string author, int timeVideo)
    {
        _titleV = title;
        _author = author;
        _timeVideo = timeVideo;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }

    public void DisplayInfoVideo()
    {
        Console.WriteLine($"\nTitle: {_titleV}\n" +
                          $"Author: {_author}\n"  +
                          $"Duration: {_timeVideo}s"+
                        "");
        Console.WriteLine("Comments:");
        
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }

        Console.WriteLine($"Number of Comments: {GetNumberComments()}\n"); 
    }
}