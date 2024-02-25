using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// 
/// Links:
/// https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-7.0&tabs=visual-studio
/// </summary>
namespace HostedService_demo
{
    public class ExampleHostedService : IHostedService
    {
        private readonly ILogger<ExampleHostedService> _logger;

        public ExampleHostedService(
        ILogger<ExampleHostedService> logger)
        {
            _logger = logger;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(ExampleHostedService)}: Hosted Service is starting.");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{nameof(ExampleHostedService)}: Hosted Service is stopping.");
        }
    }
}
