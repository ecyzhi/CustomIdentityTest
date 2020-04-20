using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomIdentityTest.Models
{
    public class ApplicationRole:IdentityRole
    {
        public override string Id { get; set; }
        public override string Name { get; set; }
    }
}
