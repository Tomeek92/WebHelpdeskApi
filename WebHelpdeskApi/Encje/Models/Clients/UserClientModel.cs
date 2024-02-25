using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskMVC.Encje.Models.Clients
{
    public class UserClientModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
    }
}
