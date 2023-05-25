using BrokerExample.Application.Ports;
using BrokerExample.Domain.Entities;

namespace BrokerExample.Infrastructure.Queues
{
    public class RabbitMQClient : IQueueService
    {
        public Task<Message> ConsumeMessage()
        {
            throw new NotImplementedException();
        }

        public Task ProduceMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
