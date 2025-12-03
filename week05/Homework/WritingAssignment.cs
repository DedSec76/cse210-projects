
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructors
    public WritingAssignment (string studentName, string topic, string title): base(studentName, topic)
    {
        _title = title;
    }

    //a method to get the writing information which consists of the title and the student's name (for example, "The Causes of World War II by Mary Waters").
    //Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}