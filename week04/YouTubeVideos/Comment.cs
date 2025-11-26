
public class Comment
{
    private string _namePerson;
    private string _comment;

    public Comment(string namePerson, string comment)
    {
        _namePerson = namePerson;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"- {_namePerson}\n{_comment}\n");
    }
}