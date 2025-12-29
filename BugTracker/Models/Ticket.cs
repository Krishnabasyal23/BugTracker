namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        // foreign keys
        public int TicketStatusId { get; set; }
        public int TicketPriorityId { get; set; }
        
        // naviation properties
        public TicketStatus TicketStatus { get; set; }
        public TicketPriority TicketPriority { get; set; }



    }
}
