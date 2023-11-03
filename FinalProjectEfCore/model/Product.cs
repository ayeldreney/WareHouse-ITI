using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class Product
    {


       


        [Key]

        public int Product_Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Product_Name { get; set; }

        [ForeignKey("WareHouse")]
        public int WareHouse_fk { get; set; }
        public WareHouse WareHouse { get; set; }
        [NotMapped]
        public virtual ICollection<UnitOfMesurement> UnitOfMesurements { get; set; }
        public List<ProductUnit> productUnits { get; set; }

        public virtual SupplyPermission SupplyPermission { get; set; }  

    }
}
