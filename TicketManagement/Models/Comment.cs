using System;
using System.Collections.Generic;

namespace TicketManagement.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
