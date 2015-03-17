﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Login
    {
        [Required]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}