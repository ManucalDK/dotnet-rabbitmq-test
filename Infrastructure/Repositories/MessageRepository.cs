using BrokerExample.Application.Ports;
using BrokerExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BrokerExample.Infrastructure.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Message?> GetMessageById(string Id)
        {
            var Message = await _context.Messages.FindAsync(Id);
            return Message;
        }

        public async Task<IEnumerable<Message>> GetMessages(int pageNumber, int pageSize)
        {
            var Messages = await _context.Messages
                .OrderByDescending(e => e.RegistrationDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Messages;
        }

        public async Task SaveMessage(Message message)
        {
            await _context.Messages.AddAsync(message);
        }

    }
}
