using Microsoft.EntityFrameworkCore;
using Fruit_Shop.Models;

namespace Fruit_Shop.Date
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
