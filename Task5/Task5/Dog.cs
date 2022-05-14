public class Dog : IAnimal
{
	public void Eat()
	{
		Console.WriteLine("Dog is eating meat...");
	}

	public void Walk()
	{
		Console.WriteLine("Dog is walking outside...");
	}

	public void Talk()
	{
		Console.WriteLine("Woof!");
	}
}
