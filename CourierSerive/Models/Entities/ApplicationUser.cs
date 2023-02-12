
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CourierSerive.Models.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string Prefix { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string State { get; set; }

        [MaxLength(50)]
        public string City { get; set; }


        [DataType(DataType.Text)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string PostalCode { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public string UserRole { get; set; }

        public Guid? CustomerId { get; set; }

        public DateTime RefreshTokenExpiry { get; set; }

        public bool FirstTimeLogin { get; set; }

        public bool IsLoggedIn { get; set; }


    }
}