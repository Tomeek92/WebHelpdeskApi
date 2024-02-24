using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskApi.Models.RegisterAndLoginModels
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
