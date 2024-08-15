using System.ComponentModel.DataAnnotations;

namespace Blazor_LoginForm_Dashboard.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}