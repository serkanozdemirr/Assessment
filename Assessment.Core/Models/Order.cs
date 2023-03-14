﻿namespace Assessment.Core.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string CustomerId { get; set; }
		public int EmployeeId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime RequiredDate { get; set; }
		public string ShippedDate { get; set; }
		public int ShipVia { get; set; }
		public double Freight { get; set; }
		public string ShipName { get; set; }
		public Address ShipAddress { get; set; }
		public List<OrderDetail> Details { get; set; }

	}
}
