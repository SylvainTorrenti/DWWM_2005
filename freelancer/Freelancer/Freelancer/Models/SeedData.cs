using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Freelancer.Data;
using System;
using System.Linq;


namespace Freelancer.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FreelancerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FreelancerContext>>()))
            {
                
                if (context.Customers.Any())
                {
                    return;   
                }

                context.Customers.AddRange(
                    new Customers
                    {
                        Name = "Mark Zoukerbergue",
                        Email = "mark@gmail.com",
                    },

                    new Customers
                    {
                        Name = "Jean Thil",
                        Email = "jeanh@domain.com",
                    },

                    new Customers
                    {
                        Name = "Jessie Aboard",
                        Email = "jaboard@domaine.com",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
