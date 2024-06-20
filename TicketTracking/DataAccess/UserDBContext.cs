using Microsoft.EntityFrameworkCore;
using TicketTracking.Models.DBEntities;

namespace TicketTracking.DataAccess
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; } 

    }
}
