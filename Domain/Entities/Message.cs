namespace BrokerExample.Domain.Entities
{
    public class Message
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ProcessingDate { get; set; }

        public Message(string body)
        {
            Id = Guid.NewGuid().ToString();
            Body = body;
            RegistrationDate = DateTime.UtcNow;
        }
    }
}
