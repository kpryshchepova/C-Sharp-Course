public class Customer
{
	public string Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public Customer(string id, string firstName, string lastName)
	{
		Id = id;
		FirstName = firstName;
		LastName = lastName;
	}
}
