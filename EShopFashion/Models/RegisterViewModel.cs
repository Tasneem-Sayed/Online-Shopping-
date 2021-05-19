using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="{0} is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string  ConfirmPassword { get; set; }
        [Range(20,60)]
        public int Age { get; set; }
        [RegularExpression("^d{3}-d{2}$")]
        public string PhoneNumber { get; set; }
    }
}
