using System;
using System.Collections.Generic;

namespace TicketManagement.Models
{
    public partial class Category
    {
        public Category()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
