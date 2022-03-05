using Core.Services;
using Worker.Models;

namespace Sandbox.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IFieldNameProvider _fieldNameProvider;

        public Worker(ILogger<Worker> logger, IFieldNameProvider fieldNameProvider)
        {
            _logger = logger;
            _fieldNameProvider = fieldNameProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var type = typeof(Company);

            var fields = _fieldNameProvider.GetFieldName(type);


            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }

            
        }
    }
}