namespace BrokerExample.Application.Dtos
{
    public class MessageDto
    {
        public string Body { get; set; }

        public MessageDto(string body)
        {
            Body = body;
        }
    }
}
