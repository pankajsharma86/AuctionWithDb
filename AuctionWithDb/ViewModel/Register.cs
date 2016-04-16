using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionWithDb.ViewModel
{
    public class Register
    {   
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Minimum required password is 8 characters")]
        public string Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage ="Confirm password do not match with original password")]
        public string ConfirmPassword { get; set; }
       
    }
}