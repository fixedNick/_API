using _API.Models;
using Microsoft.EntityFrameworkCore;

namespace _API.Context
{
    public class AchievmentsContext : DbContext
    {
        public AchievmentsContext(DbContextOptions<AchievmentsContext> opts) : base(opts)
        {

        }

        public DbSet<Achievment> Achievments { get; set; }
    }
}
