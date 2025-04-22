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

        public DbSet<House> Houses { get; set; }       
    }
}