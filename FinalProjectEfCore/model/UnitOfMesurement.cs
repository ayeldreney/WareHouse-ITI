using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{

  
    public class UnitOfMesurement
    {
        [Key]
        public int UnitOfMesurement_Id { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string UnitOfMesurement_Name { get; set; }
  

        public virtual ICollection<Product> Products { get; set; }    
    public List<ProductUnit> productUnits { get; set; } 

    }
}
