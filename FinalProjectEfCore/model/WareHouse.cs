using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class WareHouse
    {
        [Key]
        public int WareHouse_Id { get; set; }

        [Required]
        [MaxLength(20)]
        public String WareHouse_Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string WareHouse_Address { get; set;}

        [ForeignKey("Company")]
        public int Company_fk { get; set; }
       
        public Company Company { get; set;}


      

       


        public virtual List<Product> Products { get; set; } 



        public virtual SupplyPermission SupplyPermission { get; set; }      




    }
}
