using MicroBlogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroBlogAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Post> Post { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
