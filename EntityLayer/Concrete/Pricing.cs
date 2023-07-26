using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Pricing
    {
        [Key]

        public int PricingID { get; set; }

        public string? Title { get; set;}

        public string? ImageUrl { get; set; }

        public string? ServiceType { get; set; }

        public int Pricy { get; set; }

        public string? Description { get; set; }
    }
}
