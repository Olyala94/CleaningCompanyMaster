﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Home
    {
        [Key]

        public int FeatureID { get; set; }

        public string? Header { get; set; }        

        public string? Title { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
