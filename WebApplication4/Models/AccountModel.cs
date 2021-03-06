﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;


namespace WebApplication4.Models
{
    
    public class AccountModel
    {
        public string nombre { get; set; }
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }
    }
}