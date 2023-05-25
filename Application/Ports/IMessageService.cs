using BrokerExample.Application.Dtos;
using BrokerExample.Domain.Entities;

namespace BrokerExample.Application.Ports
{
    public interface IMessageService
    {
        Task<IEnumerable<Message>> GetMessages(int pageNumber, int pageSize);
        Task<Message?> GetMessageById(string Id);
        Task SaveMessage(MessageDto message);
    }
}
