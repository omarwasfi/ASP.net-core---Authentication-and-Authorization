using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAuthenticationWithGoogle.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuthenticationWithGoogle.Data
{
    public class GContext : IdentityDbContext<GUser>
    {
        public GContext(DbContextOptions<GContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
