using _API.Models;
using Microsoft.EntityFrameworkCore;

namespace _API.Context
{
    public class ArticlesContext : DbContext
    {
        public ArticlesContext(DbContextOptions<ArticlesContext> opts) : base(opts)
        {

        }

        public DbSet<Article> Articles { get; set; }
    }
}
