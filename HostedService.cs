using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace HostedService_demo
{
    public class HostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
