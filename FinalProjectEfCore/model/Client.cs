using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class Client
    {

        [Key]
        public int Client_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Client_Name { get; set; }    
        public string Client_Fax { get; set; }
        public string Client_Phone { get; set; }
        [Required]
        [MaxLength(20)]
        public string Client_EMail { get; set; } 
        public string Client_Website_Url { get; set; }
        [ForeignKey("Company")]
        public int Company_fk { get; set; }
        public Company Company { get; set; }
    }
}
