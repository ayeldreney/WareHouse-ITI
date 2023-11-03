using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Supplier_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Supplier_Name { get; set; }
        public string Supplier_Fax { get; set; }
        public string Supplier_Phone { get; set; }
        [Required]
        [MaxLength(20)]
        public string Supplier_EMail { get; set; }
        public string Supplier_Website_Url { get; set; }
        [ForeignKey("Company")]
        public int Company_fk { get; set; }
        public Company Company { get; set; }    

        public virtual SupplyPermission SupplyPermission { get; set; }  

    }
}
