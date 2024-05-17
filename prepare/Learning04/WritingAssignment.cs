public class WritingAssignment : Assignment
{
    private string _title;
    // private string _problems;

     // Constructor
    public WritingAssignment (string studentName, string topic, string title)
        : base(studentName, topic)
    {
        
        _title = title;
        // _problems = problems;
    }

    
    public string GetWritingInformation()
    {
        
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}

