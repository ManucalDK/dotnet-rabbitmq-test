using BrokerExample.Application.Dtos;
using BrokerExample.Application.Ports;
using BrokerExample.Domain.Entities;

namespace BrokerExample.Application.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IQueueService _queueService;
        private readonly ILogger<MessageService> _logger;

        public MessageService(IMessageRepository messageRepository, IQueueService queueService, ILogger<MessageService> logger)
        {
            _messageRepository = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));
            _queueService = queueService ?? throw new ArgumentNullException(nameof(queueService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Message?> GetMessageById(string Id)
        {
            return await _messageRepository.GetMessageById(Id);
        }

        public async Task<IEnumerable<Message>> GetMessages(int pageNumber, int pageSize)
        {
            return await _messageRepository.GetMessages(pageNumber, pageSize);
        }

        public async Task SaveMessage(MessageDto messageDto)
        {
            var message = new Message(messageDto.Body);
            await _queueService.ProduceMessage(message);
        }
    }
}
