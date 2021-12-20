using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFE.Models
{
    public class SellerRegistration
    {
        [Required(ErrorMessage = "GST is required")]
        [Display(Name = "GST")]
        public string Gst { get; set; }
        [Required(ErrorMessage = "Contact Number is required")]
        [Display(Name = "Company's Contact")]
        public decimal CompanyContact { get; set; }
        [Required(ErrorMessage = "Company Name is required")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}
