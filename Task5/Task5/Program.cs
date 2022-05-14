class Task5
{
    static void Main()
    {
        Cat cat = new Cat();
        Dog dog = new Dog();
        Cow cow = new Cow();
        Chicken chicken = new Chicken();
        Lion lion = new Lion();

        Console.WriteLine("\nPets group");
        Group pets = new Group();

        pets.Add(cat);
        pets.Add(dog);
        pets.Add(chicken);
        pets.Add(cow);
        pets.Add(lion);
        pets.Remove(lion);

        pets.Show();

        Console.WriteLine("\nSmall animals group");
        Group smallAnimals = new Group();

        smallAnimals.Add(cat);
        smallAnimals.Add(dog);
        smallAnimals.Add(chicken);

        smallAnimals.Show();

        Console.WriteLine("\nHunters group");
        Group hunters = new Group();

        hunters.Add(lion);
        hunters.Add(dog);

        hunters.Show();
    }
}
