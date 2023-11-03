using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class DismissalNotice
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DismissalNotice_Id { get; set; }

        public string DismissalNotice_Date { get; set; }

    
        [ForeignKey("WareHouse")]
        public int wareHouse_fk { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        [ForeignKey("Supplier")]
        public int supplier_fk { get; set; }

        public Supplier Supplier { get; set; }



      
    }
}
