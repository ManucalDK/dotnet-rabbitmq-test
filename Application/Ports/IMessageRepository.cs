using BrokerExample.Domain.Entities;

namespace BrokerExample.Application.Ports
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetMessages(int pageNumber, int pageSize);
        Task<Message?> GetMessageById(string Id);
        Task SaveMessage(Message message);
    }
}
