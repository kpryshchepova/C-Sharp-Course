public class Order
{
	public string Id { get; set; }
	public Customer Customer { get; set; }
	public List<Product> Products { get; set; }
	public bool IsOrderPaid { get; set; }

	public Order(string id, Customer customer, List<Product> products, bool isOrderPaid = false)
	{
		Id = id;
		Customer = customer;
		Products = products;
		IsOrderPaid = isOrderPaid;
	}

}
