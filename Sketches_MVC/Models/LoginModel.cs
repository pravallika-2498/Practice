using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sketches_MVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public String UserName { get; set; }
     
        [Required(ErrorMessage = "Password is required.")]
        
        public String Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Mobile NO. is required.")]
        public int Mobile { get; set; }


    }
}
