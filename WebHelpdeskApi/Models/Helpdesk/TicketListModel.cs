using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebHelpdeskApi.Models.Helpdesk
{
    public class TicketListModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public DateTime CloseTime { get; set; }



    }
}
