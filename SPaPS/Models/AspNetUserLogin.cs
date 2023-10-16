﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPaPS.Models
{
    public partial class AspNetUserLogin
    {
       
        
        public string LoginProvider { get; set; } = null!;
    
        public string ProviderKey { get; set; } = null!;
       
       
        public string? ProviderDisplayName { get; set; }
     
        public string UserId { get; set; } = null!;

        public virtual AspNetUser User { get; set; } = null!;
    }
}
