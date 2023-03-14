namespace Assessment.Core.Models
{
	public class OrderDetail
	{
		public int ProductId { get; set; }
		public double UnitPrice { get; set; }
		public double Quantity { get; set; }
		public double Discount { get; set; }
	}
}
