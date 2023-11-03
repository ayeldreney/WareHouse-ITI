using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class Company
    {

        [Key]
        public int Company_Id { get; set; }
       
        [Required]
        [MaxLength(20)]
        public string Company_Name { get; set; }


        public virtual ICollection<WareHouse> WareHouse { get; set; } = new HashSet<WareHouse>();    


        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }


    }
}
