using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookieExample.Models
{
    public class Account
    {
        public string Username { get; set; }
        public int  Password { get; set; }
        public bool RememberMe { get; set; }
    }
}