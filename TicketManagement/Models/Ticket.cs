using System;
using System.Collections.Generic;

namespace TicketManagement.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public int? AssignedTo { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? AssignedToNavigation { get; set; }
        public virtual Category? Category { get; set; }
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
