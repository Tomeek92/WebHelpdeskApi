using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebHelpdeskApi.Models.Helpdesk
{
    public class TicketCreateModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public StatusModel Status { get; set; } = default!;
        public DateTime CloseTime { get; set; }
        public TicketTypeModel TicketType { get; set; } = default!;



    }
}
