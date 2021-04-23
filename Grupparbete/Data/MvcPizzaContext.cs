using Microsoft.EntityFrameworkCore;
using Grupparbete.Models;

namespace Grupparbete.Data
{
    public class MvcPizzaContext : DbContext
    {
        public MvcPizzaContext(DbContextOptions<MvcPizzaContext> options)
            : base(options)
        {
        }

        public DbSet<Pizzas> Pizzas { get; set; }
    }
}