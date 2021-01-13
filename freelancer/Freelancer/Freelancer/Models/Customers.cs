using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Display(Name="Nom")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
