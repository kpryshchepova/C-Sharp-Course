
public class Group
{
	List<IAnimal> groupedAnimals = new List<IAnimal>();

	public void Add(IAnimal animalToAdd)
    {
        groupedAnimals.Add(animalToAdd);
        Console.WriteLine("{0} was added to group", animalToAdd);
    }

    public void Remove(IAnimal animalToRemove)
    {
        groupedAnimals.Remove(animalToRemove);
        Console.WriteLine("{0} was removed from the group", animalToRemove);
    }

    public void Show()
    {
        Console.WriteLine("\n");
        foreach (IAnimal animal in groupedAnimals) Console.WriteLine(animal);
    }
}
