using BrokerExample.Domain.Entities;

namespace BrokerExample.Application.Ports
{
    public interface IQueueService
    {
        Task<Message> ConsumeMessage();
        Task ProduceMessage(Message message);
    }
}
