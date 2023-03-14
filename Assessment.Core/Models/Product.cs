namespace Assessment.Core.Models
{
	public class Product
	{
		public int Id { get; set; }
		public int SupplierId { get; set; }
		public int CategoryId { get; set; }
		public string QuantityPerUnit { get; set; }
		public double UnitPrice { get; set; }
		public double UnitsInStock { get; set; }
		public double UnitsOnOrder { get; set; }
		public int ReorderLevel { get; set; }
		public bool Discontinued { get; set; }
		public string Name { get; set; }
		public Supplier Supplier { get; set; }
		public Category Category { get; set; }

	}
}
