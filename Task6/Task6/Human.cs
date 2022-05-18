public class Human
{
	public Human(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}

	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }

	public virtual void Walk()
    {
		Console.WriteLine("I can walk!");
    }

	public void Eat()
	{
		Console.WriteLine("I can eat!");
	}

}
