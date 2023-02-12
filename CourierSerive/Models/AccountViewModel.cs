using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourierSerive.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {

        //[BsonRepresentation(BsonType.ObjectId)]
        //public string _id { get; set; }

        [Required(ErrorMessage = "Email Address is Required")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }


        public string EmailConfirmed { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        // [EmailAddress (ErrorMessage = "Please Type a Valid Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        [Display(Name = "Email Address/User ID")]
        public string Email { get; set; }

        [RegularExpression("^(?=.*[\\d])(?=.*[A-Z])(?=.*[a-z])[\\w\\d!@#$%^&*()=+?-]{6,40}$", ErrorMessage = "Password does not meet its criteria")]
        //[Required(ErrorMessage = "Password is Required")]
        //[StringLength(100, ErrorMessage = "Password must be 8 character long with an alphabet, number and special character", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        //[Compare("Password", ErrorMessage = "Password and confirmation password doesn't match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Role Name is Required")]
        [Display(Name = "Register As")]
        public string RoleName { get; set; }

        // -------------------------SPONSOR_PROVIDER----------------------------------//

        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        //[Display(Name = "Contact Person Name")]
        //[Required (ErrorMessage ="Contact Person Name Required")]
        //public string ContactPersonName { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        [RegularExpression("[A-Za-z0-9- ,.?!'():;\"]+", ErrorMessage = "Allow Alphanumeric Input With Punctuation only")]
        public string Address { get; set; }

        //[Required(ErrorMessage = "Address 2 is Required")]
        [Display(Name = "Address 2")]
        [RegularExpression("[A-Za-z0-9- ,.?!'():;\"]+", ErrorMessage = "Allow Alphanumeric Input With Punctuation only")]
        public string Address2 { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "State is Required")]

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        public string State { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "Country Name is Required")]
        public string Country { get; set; }

        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        //[Required (ErrorMessage = "Mobile Number is Required")]
        [RegularExpression("^[0-9+]*$", ErrorMessage = "Allow Numbers, '+' only ")]
        [Display(Name = "Mobile Phone")]
        public string PhoneNumber { get; set; }

        [RegularExpression("^[0-9+]*$", ErrorMessage = "Allow Numbers, '+' only ")]
        [Required(ErrorMessage = "Office Number is Required")]
        [Display(Name = "Office Phone")]
        public string LandlineNumber { get; set; }

        [RegularExpression(@"^[0-9a-zA-Z-]+$", ErrorMessage = "Allow Alphanumeric and hyphen '-'")]
        [StringLength(30, MinimumLength = 1)]
        //[RegularExpression(@"^(?=.*[a-zA-Z\d].*)[a-zA-Z\d!@#$%&*]{7,}$", ErrorMessage = "Allow Alphanumeric Input only")]
        [Required(ErrorMessage = "Zip Code is Required")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Provider URL")]
        [Required(ErrorMessage = "Provider URL is Required")]
        public string Website { get; set; }
        public string Status { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Comments { get; set; }


        // -------------------------SPONSORUSER_PROVIDERUSER----------------------------------//

        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]

        [RegularExpression("^[a-zA-Z- ]*$", ErrorMessage = "Allow alphabets, '-' only ")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [RegularExpression("^[a-zA-Z- ]*$", ErrorMessage = "Allow alphabets, '-' only ")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }
        public DateTime CreateDate { get; set; }

        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "Provider Name is Required")]
        [Display(Name = "Provider Name")]
        public string ProviderName { get; set; }
        
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        public string Ext { get; set; }
        public string RBPhoneNumberPreference { get; set; }
        public string RBDepartmentTitle { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Display(Name = "Contact Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string ContactEmail { get; set; }

        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [Display(Name = "Contact Phone")]
        [RegularExpression("^[0-9+]*$", ErrorMessage = "Allow Numbers, '+' only ")]
        public string ContactPhone { get; set; }


        
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class RegistrationFormViewModel
    {
        //Email
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Please Type a Valid Email Address")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //RoleName
        [Required(ErrorMessage = "Role Name is Required")]
        [Display(Name = "Register As")]
        public string RoleName { get; set; }

        //Address1
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        //Address2
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        //City
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }


        //State
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }

        //Country
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "Country Name is Required")]
        public string Country { get; set; }

        //PhoneNumber
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        [Required(ErrorMessage = "Phone Number is Required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        //MobileNumber
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        //[Required(ErrorMessage = "Mobile Number is Required")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        //ZipCode
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        [Required(ErrorMessage = "Zip Code is Required")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        //FirstName
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }

        //LastName
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }


        //ProviderName
        //[RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Enter Alphabets Only")]
        [Required(ErrorMessage = "Company Name is Required")]
        [Display(Name = "Company Name")]
        public string ProviderName { get; set; }

        //Extension
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Must be in numeric format")]
        public string Ext { get; set; }

        //Comments
        public string Comments { get; set; }
    }

}