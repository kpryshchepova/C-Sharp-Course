public class GenerateId
{
	public string GenerateStringId()
	{
		return Guid.NewGuid().ToString("N");
	}
}
