namespace Assessment.Core.Models
{
	public class Supplier
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public Address Address { get; set; }

	}
}
