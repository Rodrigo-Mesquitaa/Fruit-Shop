using Fruit_Shop.Models;
using System.Linq;

namespace Fruit_Shop.Date
{
    public static class SeedData
    {
        public static void Initialize(SampleContext context)
        {
            if (!context.Fruits.Any())
            {
                context.Fruits.AddRange(
                    new Fruit { Name = "Apple" },
                    new Fruit { Name = "Orange" },
                    new Fruit { Name = "Strawberry" }
                );

                context.SaveChanges();
            }

            if (!context.People.Any())
            {
                context.People.AddRange(
                    new Person { Name = "Homem de Ferro" },
                    new Person { Name = "Feiticeira Scarllat" },
                    new Person { Name = "Viuva Negra" }
                );

                context.SaveChanges();
            }
        }
    }
}