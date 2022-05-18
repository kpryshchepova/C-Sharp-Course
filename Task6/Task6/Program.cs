class Task6
{
    static void Main()
    {
        Girl girl1 = new Girl("Kate", "Pr", 24, false);
        Boy boy1 = new Boy("John", "Smith", 30, true);
        Console.WriteLine("\nMy name is {0} {1}. I'm {2} years old.", girl1.FirstName, girl1.LastName, girl1.Age);
        girl1.Walk();
        girl1.Eat();
        if (girl1.IsRedLips)
        {
            Console.WriteLine("And I have red lips!");
        }

        Console.WriteLine("\nMy name is {0} {1}. I'm {2} years old.", boy1.FirstName, boy1.LastName, boy1.Age);
        boy1.Walk();
        boy1.Eat();
        if (boy1.HasBeard)
        {
            Console.WriteLine("And I have beard!");
        }

    }
}
