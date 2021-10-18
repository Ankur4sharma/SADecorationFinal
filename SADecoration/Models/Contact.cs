using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SADecoration.Models
{
    public class Contact
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Contact No")]
        public string Mobile { get; set; }



        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Date")]
        public string sDate { get; set; }


    }
}
