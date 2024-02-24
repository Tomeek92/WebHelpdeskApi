using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskApi.Models.RegisterAndLoginModels
{
    public class UserRegisterModel
    {
       
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }

    }
}
