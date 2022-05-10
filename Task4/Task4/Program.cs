class Task4
{
    static void Main()
    {
        Customer John = new Customer(new GenerateId().GenerateStringId(), "John", "Smith");
        Customer Kate = new Customer(new GenerateId().GenerateStringId(), "Kate", "Pr");

        Shop shop = new Shop();
        shop.FullProductList();

        Console.WriteLine("\nCreating order for John with 1 product...");
        shop.AddNewOrder(John, new List<Product> { shop.products[2] }, false);
        Console.WriteLine("\nCreating order for Kate with 0 product...");
        shop.AddNewOrder(Kate, new List<Product> { }, true);

        Console.WriteLine("\nAdding wrong product...");
        shop.AddNewProductToOrder(John.Id, "Pasta");
        Console.WriteLine("\nAdding right product...");
        shop.AddNewProductToOrder(John.Id, "Cheese");

        Console.WriteLine("\nPaying existing order...");
        shop.PayOrder(John.Id);
        Console.WriteLine("\nPaying non existing order...");
        shop.PayOrder(Kate.Id);

        Console.WriteLine("\nAdding product for paid order...");
        shop.AddNewProductToOrder(John.Id, "Cheese");
    }
} 
