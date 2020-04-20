using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentityTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string Email { get; set; }
        public override string UserName { get; set; }
        public string Password { get; set; }
    }
}
