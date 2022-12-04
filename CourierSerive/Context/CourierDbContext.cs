using CourierSerive.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourierSerive.Context
{
    public class CourierDbContext:DbContext
    {
        public CourierDbContext():base("name=CourierDbContext") 
        { 

        }

        public DbSet<Booking> Booking { get; set; }
    }
}