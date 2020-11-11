
using System.ComponentModel.DataAnnotations;


namespace TheTest.Server.Data.Models.identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
