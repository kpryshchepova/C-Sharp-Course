public class Student
{
    public string FirstName;
    public string LastName;
    public Mark[] Marks;

    public Student(string firstName, string lastName, Mark[] marks)
    {
        FirstName = firstName;
        LastName = lastName;
        Marks = marks;
    }

    public float GetAvgMark()
    {
        int allMarks = 0;
        foreach (Mark mark in Marks)
           allMarks += mark.Value;

        return (float)allMarks / (float)Marks.Length;
    }

    public void ResetAllMarks()
    {
        foreach (Mark mark in Marks)
            mark.Value = 0;
    }
}
