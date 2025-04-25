using DemoWeb.DataBaseContext.DbModels;
using Microsoft.EntityFrameworkCore;

namespace DemoWeb.DataBaseContext
{
    internal class DemoDbContext: DbContext
    {
       
        private readonly string _connectionString;

        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the entity properties and relationships here
            modelBuilder.Entity<House>().Configure();
        }

        public DbSet<House> Houses { get; set; }       
    }
}