public class Boy : Human
{
	public Boy(string firstName, string lastName, int age, bool hasBeard) : base(firstName, lastName, age)
	{
		HasBeard = hasBeard;
	}

	public bool HasBeard { get; set; }

	public override void Walk()
	{
		Console.WriteLine("I can walk barefoot!");
	}
}
