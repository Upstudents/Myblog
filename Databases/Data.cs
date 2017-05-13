using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Databases
{
public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}