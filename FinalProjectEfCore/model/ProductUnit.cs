using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.model
{
    public class ProductUnit
    {
        public int Product_Id { get; set; } 

        public Product Product { get; set; }        


        public int UnitOfMesurement_Id {get; set; } 

        public UnitOfMesurement UnitOfMesurement { get; set;}



    }
}
