using System.ComponentModel.DataAnnotations;

namespace RollOff_Test4API.Models.Domain
{
    public class Login
    {
        [Key]
        public int Id {get;set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
