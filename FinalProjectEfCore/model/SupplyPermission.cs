using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class SupplyPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplyPermission_Id { get; set; }
       
        public string SupplyPermission_Date { get; set;}

        public int quantity {get; set;} 

        public string SupplyPermission_expiry { get; set; }
        [ForeignKey("WareHouse")]
        public int wareHouse_fk { get; set; }   
        public virtual WareHouse WareHouse { get; set; }
        [ForeignKey("Supplier")]
        public int supplier_fk { get; set; }    

        public Supplier Supplier { get; set; }  



        public ICollection<Product> products { get; set; }  

        


    }
}
