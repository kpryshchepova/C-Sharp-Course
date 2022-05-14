public class Cat : IAnimal
{
	public void Eat()
	{
		Console.WriteLine("Cat is eating sausages...");
	}

	public void Walk()
	{
		Console.WriteLine("Cat is walking on the roof...");
	}

	public void Talk()
	{
		Console.WriteLine("Meow!");
	}
}
