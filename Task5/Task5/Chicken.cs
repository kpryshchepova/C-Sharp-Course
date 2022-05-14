public class Chicken : IAnimal
{
	public void Eat()
	{
		Console.WriteLine("Chicken is eating corn...");
	}

	public void Walk()
	{
		Console.WriteLine("Chicken is walking in the barn...");
	}

	public void Talk()
	{
		Console.WriteLine("Cluck!");
	}
}
