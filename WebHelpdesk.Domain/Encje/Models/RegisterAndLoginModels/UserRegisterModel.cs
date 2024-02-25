using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskApi.Models.RegisterAndLoginModels
{
    public class UserRegisterModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; } 
        [Required]
        public string UserEmail { get; set; }
        
          

    }
}
