using CozyCo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CozyCo.Data.Context
{
    // DbContext -> represent a session to a db APIs
    // to communicate with db
    public class CozyCoDbContext : DbContext
    {
        // Represents a collection (table) of a given entity/model
        // They map to tables by default
        DbSet<Property> Properties { get; set; }

        //Virtual medthod designed to be overridden
        // You can provide configuration information for the context
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string is divided in 3 elements
            //server - database - authentication 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=cozyco;Trusted_Connection=true");
        }
    }
}