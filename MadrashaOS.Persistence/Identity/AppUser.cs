using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadrashaOS.Infrastructure.Identity
{
    public class AppUser : IdentityUser
    {
        // You can extend the IdentityUser class by adding additional properties here
        public string FullName { get; set; }
    }
}
