using CCS.MonolithWebApi.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace CCS.MonolithWebApi.Persistences.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Sample> Sample { get; set; }
    }
}
