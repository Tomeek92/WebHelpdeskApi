using System.ComponentModel.DataAnnotations;

namespace WebHelpdeskApi.Models.Clients
{
    public class ClientModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PostCode {  get; set; }
        [Required]
        public int Nip { get; set; }
    }
}
