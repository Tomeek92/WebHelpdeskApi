using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHelpdeskApi.Models.Helpdesk;

namespace WebHelpdesk.Domain.Encje.Models.Helpdesk
{
    public class TicketListModel
    {
        [Key]
        public Guid Id { get; set; }
        public TicketCreateModel Title { get; set; } = default!;
        public TicketCreateModel Description {  get; set; } = default!;
        public TicketTypeModel TicketType { get; set; } = default!;
        public StatusModel Status { get; set; } = default!;
        public PriorityModel Priority { get; set; } = default!;

    }
}
