using System;
using Microsoft.EntityFrameworkCore;
namespace forum.Data.Models
{
    public class AppDBContent : DbContext
    {
        public DbSet<Message> messages { get; set; }
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Thread> Thread { get; set; }
        

    }
}
