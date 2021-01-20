using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Quotes
    {
        [Key]
        public int quote_id { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un état")]
        [StringLength(10, ErrorMessage = "Limite maximum de caractères : 10")]
        public char quote_state { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir une date")]
        [DataType(DataType.Date)]
        public DateTime quote_date { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un montant")]
        public int quote_amount { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date finale")]
        public DateTime quote_final_date { get; set; }

        [Display(Name = "Montant final")]
        public int quote_final_amount { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez renseigner une mission")]
        [ForeignKey("Jobs")]
        public int job_id { get; set; }
    }
}
