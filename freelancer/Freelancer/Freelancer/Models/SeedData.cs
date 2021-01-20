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
                        customer_name = "Mark Zoukerbergue",
                        customer_email = "mark@gmail.com",
                    },

                    new Customers
                    {
                        customer_name = "Jean Thil",
                        customer_email = "jeanh@domain.com",
                    },

                    new Customers
                    {
                        customer_name = "Jessie Aboard",
                        customer_email = "jaboard@domaine.com",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
