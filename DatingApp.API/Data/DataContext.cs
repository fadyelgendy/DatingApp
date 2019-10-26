using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        //scaffold the tables class to database model
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // create values table
        public DbSet<Value> Values { get; set; } // represnt the values table in sql db
    }

}