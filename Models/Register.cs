using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Swa.Models
{
    public class Register
    {
        [Required ]
        public string user { get; set; }
        public string email { get; set; }
     
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string mobile { get; set; }
    }
}