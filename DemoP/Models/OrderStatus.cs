using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DemoP.Models
{
    public partial class OrderStatus
    {
        public Guid? OrderProductId { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public string TransitionNotesComments { get; set; }

        public virtual OrderProduct OrderProduct { get; set; }
    }
}
