using BrokerExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrokerExample.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Message> Messages => Set<Message>();
    }
}
