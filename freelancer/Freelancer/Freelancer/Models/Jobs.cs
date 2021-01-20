using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Jobs
    {
        [Key]
        public int job_id { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un état")]
        [StringLength(10)]
        public string job_state { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un titre")]
        [MaxLength(100)]
        public string job_title { get; set; }

        [DataType(DataType.Date)]
        public string job_start { get; set; }

        [DataType(DataType.Date)]
        public string job_end { get; set; }

        [DataType(DataType.Text)]
        public string job_description { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez renseigner un client")]
        [ForeignKey("Customers")]
        public int customer_id { get; set; }
    }
}
