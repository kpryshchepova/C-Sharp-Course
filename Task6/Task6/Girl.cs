public class Girl : Human
{
	public Girl(string firstName, string lastName, int age, bool isRedLips) : base(firstName, lastName, age)
	{
		IsRedLips = isRedLips;
	}

	public bool IsRedLips { get; set; }

	public override void Walk()
    {
		Console.WriteLine("I can walk on heels!");
	}
}
