using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Grupparbete.Data;
using System;
using System.Linq;

namespace Grupparbete.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPizzaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPizzaContext>>()))
            {
                if (context.Pizzas.Any())
                {
                    return;
                }

                context.Pizzas.AddRange(
                    new Pizzas
                    {
                        PizzaName = "Margherita Pizza",
                        PizzaSizes = "Standard / Familje",
                        Price = 79
                    },

                    new Pizzas
                    {
                        PizzaName = "Tuna Pizza",
                        PizzaSizes = "Standard / Familje",
                        Price = 79
                    }
                );
                context.SaveChanges();
            }
        }
    }
}