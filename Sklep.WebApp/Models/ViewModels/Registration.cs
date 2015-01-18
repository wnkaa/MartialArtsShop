using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sklep.WebApp.Models.ViewModels
{
    public class RegistrationModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage="Number must be 9 numbers")]
        public string Phone { get; set; }

        

    }
}