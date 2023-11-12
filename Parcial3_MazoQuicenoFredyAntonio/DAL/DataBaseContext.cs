using Microsoft.EntityFrameworkCore;
using Parcial3_MazoQuicenoFredyAntonio.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial3_MazoQuicenoFredyAntonio.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //La siguiente línea comtrola la duplicidad de los países
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
