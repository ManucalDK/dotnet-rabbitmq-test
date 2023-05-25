namespace BrokerExample.Presentation.Workers
{
    public class WorkerConsumer : BackgroundService
    {
        private readonly ILogger<WorkerConsumer> _logger;

        public WorkerConsumer(ILogger<WorkerConsumer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation($"Back Ground Task Executed: {DateTime.UtcNow}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
