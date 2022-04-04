Mark[] JohnKartersMarks = { new Mark("Math", 4), new Mark("PI", 5), new Mark("History", 5), new Mark("Geography", 5) };
Student JohnKarter = new Student("John", "Karter", JohnKartersMarks);

Console.WriteLine("John Karter Marks:");
for (int i = 0; i < JohnKartersMarks.Length; i++)
    Console.WriteLine(JohnKartersMarks[i].Subject + " - " + JohnKartersMarks[i].Value);

Console.WriteLine("\nJohn Karter Average: " + JohnKarter.GetAvgMark());

JohnKarter.ResetAllMarks();

Console.WriteLine("\nJohn Karter Marks:");
for (int i = 0; i < JohnKartersMarks.Length; i++)
    Console.WriteLine(JohnKartersMarks[i].Subject + " - " + JohnKartersMarks[i].Value);

Console.WriteLine("\nJohn Karter Average: " + JohnKarter.GetAvgMark());

public class Student
{
    public string FirstName;
    public string LastName;
    public Mark[] Marks;

    public Student (string firstName, string lastName, Mark[] marks)
    {
        FirstName = firstName;
        LastName = lastName;
        Marks = marks;
    }

    public float GetAvgMark ()
    {
        int allMarks = 0;
        for (int i = 0; i < this.Marks.Length; i++)
            allMarks += this.Marks[i].Value;

        return (float)allMarks / (float)Marks.Length;
    }

    public void ResetAllMarks ()
    {
        for (int i = 0; i < this.Marks.Length; i++)
            this.Marks[i].Value = 0;
    }
}

public class Mark
{
    public string Subject;
    public int Value;

    public Mark (string subject, int value)
    {
        Subject = subject;
        Value = value;
    }
}
