using System;
using System.Collections.Generic;

namespace TicketManagement.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            TicketAssignedToNavigations = new HashSet<Ticket>();
            TicketCreatedByNavigations = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Ticket> TicketAssignedToNavigations { get; set; }
        public virtual ICollection<Ticket> TicketCreatedByNavigations { get; set; }
    }
}
