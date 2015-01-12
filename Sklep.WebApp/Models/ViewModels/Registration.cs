using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sklep.WebApp.Models.ViewModels
{
    public class Registration
    {
        public int UserID { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Email Address: ")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(150,MinimumLength=6)]
        [Display(Name ="Password")]
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        [Required]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }
        public string UserType { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string IPAddress { get; set; }

    }
}