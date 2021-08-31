using Bangalore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Bangalore.API.AppDbContext
{
    public class ApplicationDbContex : DbContext
    {


        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

        }


        public DbSet<Users> Users { get; set; }
     
    }
}