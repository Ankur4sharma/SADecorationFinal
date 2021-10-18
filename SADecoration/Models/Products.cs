using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SADecoration.Models
{
    public class Products
    {


        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Price")]
        public string Price { get; set; }



        [Display(Name = "Qty")]
        public string Quantity { get; set; }


        [Display(Name = "Date")]
        public string sDate { get; set; }



    }
}
