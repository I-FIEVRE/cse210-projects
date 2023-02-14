using System;

public class WritingAssignment : Assignment
{
    private string _title;


    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();  // to avoid "protected" and stay with "private"
        return $"{_title} by {studentName}";
    }
}



