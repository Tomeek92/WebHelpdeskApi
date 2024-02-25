using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskMVC.Encje.Models.RegisterAndLoginModels
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
