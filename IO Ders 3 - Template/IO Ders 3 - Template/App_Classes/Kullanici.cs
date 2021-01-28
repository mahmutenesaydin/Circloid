using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IO_Ders_3___Template.App_Classes
{
    public class Kullanici
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
    }
}