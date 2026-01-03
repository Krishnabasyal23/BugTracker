using BugTracker.Models;
namespace BugTracker.Data
{
    // static class casue we dont need to store state, run onetime setup acction. 
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Seed TicketStatus
            if (!context.TicketStatus.Any())
            {
                context.TicketStatus.AddRange(
                    new TicketStatus { Name = "Open" },
                    new TicketStatus { Name = "In Progress" },
                    new TicketStatus { Name = "Resolved" },
                    new TicketStatus { Name = "Closed" }
                );
            }
            // Seed TicketPriority
            if (!context.TicketPriority.Any())
            {
                context.TicketPriority.AddRange(
                    new TicketPriority { Name = "Low" },
                    new TicketPriority { Name = "Medium" },
                    new TicketPriority { Name = "High" },
                    new TicketPriority { Name = "Urgent" }
                );
            }
            context.SaveChanges();
        }
    }
}

