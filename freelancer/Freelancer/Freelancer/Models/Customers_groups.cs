using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Customers_groups
    {
        [Key]
        public int customer_group_id { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un nom")]
        [MaxLength(50, ErrorMessage = "Limite maximum de caractères : 50")]
        [Display(Name = "Nom du groupe")]
        public string customer_group_name { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Description du groupe")]
        public string customer_group_description { get; set; }
    }
}
