using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace Assessment.Core.Logging
{
	public class Logger : ILogger
	{

		private readonly Provider _provider;
		public Logger([NotNull] Provider provider)
		{
			_provider = provider;
		}

		public IDisposable BeginScope<TState>(TState state)
		{
			return null;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return logLevel != LogLevel.None;
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
		{
			if (!IsEnabled(logLevel))
			{
				return;
			}

			string message = exception != null ? exception.Message : formatter(state, exception);

			using (var connection = new SqlConnection(_provider.Options.ConnectionString))
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandType = System.Data.CommandType.Text;
					command.CommandText = string.Format("INSERT INTO {0} ([Message], [CreatedDate]) VALUES (@Message, @CreatedDate)", _provider.Options.LogTable);

					command.Parameters.Add(new SqlParameter("@Message", message));
					command.Parameters.Add(new SqlParameter("@CreatedDate", DateTimeOffset.Now));
					command.ExecuteNonQuery();
				}

				connection.Close();
			}
		}
	}
}
