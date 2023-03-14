using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Assessment.Core.Logging
{
	public class Provider : ILoggerProvider
	{
		public readonly Options Options;

		public Provider(IOptions<Options> _options)
		{
			Options = _options.Value;
		}
		public ILogger CreateLogger(string categoryName)
		{
			return new Logger(this);
		}

		public void Dispose()
		{
		}
	}
}