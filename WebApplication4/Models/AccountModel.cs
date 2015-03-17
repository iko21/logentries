using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;


namespace WebApplication4.Models
{
    
    public class AccountModel
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
    }
}