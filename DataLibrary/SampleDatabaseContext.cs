using DataModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary
{
    public class SampleDatabaseContext: DbContext
    {

        public DbSet<MltpUser> MltpUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5Q9K0JF\\SQLEXPRESS;Database=SampleDatabase;Trusted_Connection=True;");
            }

        }
    }
}