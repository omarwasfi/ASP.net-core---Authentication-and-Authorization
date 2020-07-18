using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Identity.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Person class
    public class Person : IdentityUser
    {
        public string FullName { get; set; }

        public List<Order> Orders { get; set; }
    }
}
