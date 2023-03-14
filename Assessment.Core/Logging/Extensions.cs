using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Assessment.Core.Logging
{
	public  static class Extensions
	{
		public static ILoggingBuilder AddDbLogger(this ILoggingBuilder builder, Action<Options> configure)
		{
			builder.Services.AddSingleton<ILoggerProvider, Provider>();
			builder.Services.Configure(configure);
			return builder;
		}
	}
}
