using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sklep.WebApp.Models.Identity
{
    public class ChangeProfile
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Street { get; set; }
        [MaxLength(9,ErrorMessage="Phone number must be 9 digits")]
        public string Phone { get; set; }
    }
}