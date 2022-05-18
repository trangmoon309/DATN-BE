using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Datn.ApiManagement.Models
{
    public class UserRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public ExtraInfors ExtraInfors { get; set; }
    }

    public class ExtraInfors
    {
        public string Age { get; set; }

        public string Address { get; set; }

        public string AvatarId { get; set; }

        public string IDNumber { get; set; }

        public string DriverLicense { get; set; }

        public string Gender { get; set; }
    }
}
