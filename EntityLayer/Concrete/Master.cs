using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Master
    {
        [Key]

        public int MasterID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Job { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }
    }
}
