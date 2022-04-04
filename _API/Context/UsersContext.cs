using _API.Models;
using Microsoft.EntityFrameworkCore;

namespace _API.Context
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> opts) : base(opts)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
