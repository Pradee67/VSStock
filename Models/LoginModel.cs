using System.ComponentModel.DataAnnotations;

namespace ProjectReactWeb.Models
{
    public class LoginModel
    {
        [Key]
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
