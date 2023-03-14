namespace Assessment.Core.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Title { get; set; }
		public string TitleOfCourtesy { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		public Address Address { get; set; }
		public string Notes { get; set; }
		public string ReportsTo { get; set; }
		public List<int> TerritoryIds { get; set; }

	}
}
