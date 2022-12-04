using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourierSerive.Models.Entities
{
    public class Booking
    {
        [Key]

        public Guid BookingId { get; set; }
        [Display(Name ="Booking Name")]
        [Required(ErrorMessage = "Please Booking Name")]
        public string BookingName { get; set; }
        [Required(ErrorMessage = "Please Enter Amount")]
        public int Amount { get; set; }

        [Display(Name = "Contact No")]
        [Required(ErrorMessage = "Please Enter Contact No")]
        public string ContactNo { get; set; }

        [Required(ErrorMessage ="Please Enter Address")]
        public string Address { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}