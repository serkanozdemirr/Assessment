namespace Assessment.Core.Logging
{
	public class Options
	{
		public string ConnectionString { get; init; }

		public string[] LogFields { get; init; }

		public string LogTable { get; init; }

		public Options()
		{
		}
	}
}
