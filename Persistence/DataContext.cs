using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Value>Values {get;set;}

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Value>()
            .HasData (
                new Value {Id = 101, Name ="Anjani"},
                new Value {Id = 102, Name = "Vasu"},
                new Value {Id = 103, Name = "Whisky"}
            );
        }
    }
}