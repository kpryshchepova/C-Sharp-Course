public class Shop
{
	public List<Order> orders = new List<Order>();
	public List<Product> products = new List<Product>();

	public void FullProductList()
    {
		products.Add(new Product(new GenerateId().GenerateStringId(), "Milk", 5.3));
		products.Add(new Product(new GenerateId().GenerateStringId(), "Bread", 6.4));
		products.Add(new Product(new GenerateId().GenerateStringId(), "Cheese", 25.8));
		products.Add(new Product(new GenerateId().GenerateStringId(), "Cucumber", 7.0));
		products.Add(new Product(new GenerateId().GenerateStringId(), "Tomato", 10.6));
	}

	public void AddNewOrder(Customer customer, List<Product> productList, bool isOrderPaid)
    {
		if (productList.Count == 0)
        {
			Console.WriteLine("Please, add some product to order!");
			return;
        } else {
			string id = new GenerateId().GenerateStringId();
			Order newOrder = new Order(id, customer, productList, isOrderPaid);
			orders.Add(newOrder);
			Console.WriteLine("Your order is successfully added!");
		}
		
    }

	public void AddNewProductToOrder(string customerId, string productName)
    {
		Product newProductToAdd = products.Find(product => product.Name == productName);
		Order order = orders.Find(order => order.Customer.Id == customerId);

		if (order == null)
		{
			Console.WriteLine("Cannot find order!");
			return;
		}
		else if (order.IsOrderPaid)
        {
			Console.WriteLine("You cannot add product to already paid order!");
			return;
		}
		else if (newProductToAdd == null) {
			Console.WriteLine("Cannot find {0}!", productName);
			return; 
		}		
		else
		{
			orders.Find(order => order.Customer.Id == customerId).Products.Add(newProductToAdd);
			Console.WriteLine("Your product is successfully added!");
		}
	}

	public void PayOrder(string customerId)
	{
		Order order = orders.Find(order => order.Customer.Id == customerId);
		if (order == null)
		{
			Console.WriteLine("Cannot find order!");
			return;
		}
		else if (order.IsOrderPaid)
			Console.WriteLine("Your order is already paid!");
		else
		{
			order.IsOrderPaid = true;
			Console.WriteLine("Your order is successfully paid!");
		}

	}
}
