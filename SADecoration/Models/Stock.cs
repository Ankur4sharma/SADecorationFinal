using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SADecoration.Models
{
    public class Stock
    {


        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Qty")]
        public string Quantity { get; set; }

        public Products products { get; set; }

    }
}
