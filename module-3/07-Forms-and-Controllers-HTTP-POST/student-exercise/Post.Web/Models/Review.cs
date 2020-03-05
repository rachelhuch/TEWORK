﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
    
            public string Username { get; set; }
            public string ReviewTitle { get; set; }
            public int Rating { get; set; }
            public string ReviewText { get; set; }
        
    }
}
