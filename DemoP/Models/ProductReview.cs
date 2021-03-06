using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DemoP.Models
{
    public partial class ProductReview
    {
        public Guid? CustomerUserId { get; set; }
        public string Review { get; set; }
        public double? Rating { get; set; }
        public Guid? ProductId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual UserTable CustomerUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
