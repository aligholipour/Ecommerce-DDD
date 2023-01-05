using Microsoft.Extensions.Hosting;

namespace BuildingBlocks.OutboxProcessor
{
    public class OutboxWorker : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}
