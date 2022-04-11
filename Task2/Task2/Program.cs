class Task2
{
    static void GetMarks(string fullName, ref Mark[] marks, out bool isExcellentStudent)
    {
        isExcellentStudent = true;

        Console.WriteLine(fullName + " Marks:");
        foreach (Mark mark in marks)
        {
            if (mark.Value < 5)
                isExcellentStudent = false;

            Console.WriteLine(mark.Subject + " - " + mark.Value);
        }
    }

    static void Main()
    {
        Mark[] JohnKartersMarks = { new Mark("Math", 5), new Mark("PI", 5), new Mark("History", 5), new Mark("Geography", 5) };
        Student JohnKarter = new Student("John", "Karter", JohnKartersMarks);

        bool isJohnExcellent;
        GetMarks("John Karter", ref JohnKartersMarks, out isJohnExcellent);

        if (isJohnExcellent) Console.WriteLine("John Karter is excellent student!");

        Console.WriteLine("\nJohn Karter Average: " + JohnKarter.GetAvgMark());

        JohnKarter.ResetAllMarks();

        GetMarks("John Karter", ref JohnKartersMarks, out isJohnExcellent);

        if (isJohnExcellent) Console.WriteLine("John Karter is excellent student!");

        Console.WriteLine("\nJohn Karter Average: " + JohnKarter.GetAvgMark());
    }
}

