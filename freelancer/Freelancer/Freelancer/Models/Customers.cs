using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Customers
    {
        [Key]
        [Display(Name ="Id")]
        public int customer_id { get; set; }
        [MaxLength(100, ErrorMessage = "Limite maximum de caractères : 100")]
        [Display(Name="Nom")]
        public string customer_name { get; set; }      
        [Display(Name ="Email")]
        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir une adresse e-mail")]        
        [MaxLength(255, ErrorMessage = "Limite maximum de caractères : 255")]
        [DataType(DataType.EmailAddress)]
        public string customer_email { get; set; }
        [Required(ErrorMessage = "Champ obligatoire : veuillez selectionner une catégorie")]
        [ForeignKey("customer_group_id")]
        [Display(Name = "Groupe")]
        public int customer_group_id { get; set; }

        public virtual Customers_groups group { get; set; }

    }
}
