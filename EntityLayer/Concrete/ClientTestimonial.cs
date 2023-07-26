﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ClientTestimonial
    {
        [Key]
        public int ClientTestimonialID { get; set; }

        public string? ClientName { get; set; }

        public DateTime Date { get; set; }

        public string? Title { get; set; }   

        public string? Comment { get; set; }   

        public string? ClientImageUrl { get; set; }   
    }
}
