public class Cow : IAnimal
{
	public void Eat()
	{
		Console.WriteLine("Cow is eating grass...");
	}

	public void Walk()
	{
		Console.WriteLine("Cow is walking on the field...");
	}

	public void Talk()
	{
		Console.WriteLine("Moo!");
	}
}
