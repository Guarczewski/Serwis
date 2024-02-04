using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serwis.Models
{
    [Table("AspNetUsers")]
    public class Worker : IdentityUser
    {
        public int PIN { get; set; }
        public String? Name { get; set; }
        public String? Surename { get; set; }
        public String? City { get; set; }
        public String? Zip_Code { get; set; }
        public String? Adress { get; set; }
        public String? Position { get; set; }
        public String? PESEL { get; set; }
    }

    public class LoginWorker
    {
        [EmailAddress]
        public required String Email { get; set; }
        [DataType(DataType.Password)]
        public required String Password { get; set; }
    }

    public class RegisterWorker
    {
        [EmailAddress]
        public required String Email { get; set; }
        [DataType(DataType.Password)]
        public required String Password { get; set; }
        [DataType(DataType.Password)]
        public required String ConfirmPassword { get; set; }
        public int PIN { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Name { get; set; }
        public String? Surename { get; set; }
        public String? City { get; set; }
        public String? Zip_Code { get; set; }
        public String? Adress { get; set; }
        public String? Position { get; set; }
        public String? PESEL { get; set; }

    }

}
