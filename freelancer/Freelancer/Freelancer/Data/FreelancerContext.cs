using Freelancer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Data
{
    public class FreelancerContext : DbContext
    {
        public FreelancerContext(DbContextOptions<FreelancerContext> options)
            : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
    }
}
