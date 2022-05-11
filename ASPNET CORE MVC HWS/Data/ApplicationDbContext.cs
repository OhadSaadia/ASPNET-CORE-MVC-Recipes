using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ASPNET_CORE_MVC_HWS.Models;

namespace ASPNET_CORE_MVC_HWS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPNET_CORE_MVC_HWS.Models.Recipe> Recipe { get; set; }
    }
}
