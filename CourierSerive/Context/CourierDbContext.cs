using CourierSerive.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourierSerive.Context
{
    public class CourierDbContext:IdentityDbContext<ApplicationUser>
    {
        public CourierDbContext():base("name=CourierDbContext") 
        { 

        }

        public DbSet<Booking> Booking { get; set; }
    }
}