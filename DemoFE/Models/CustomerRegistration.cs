using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFE.Models
{
    public class CustomerRegistration
    {
        public Guid? UserId { get; set; }
        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Customer Contact")]
        public decimal? CustomerContact { get; set; }
    }
}
