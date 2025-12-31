using BugTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPriority> TicketPriority { get; set;}
        public DbSet<TicketStatus> TicketStatus { get; set; }

    }
}
