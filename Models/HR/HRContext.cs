using Microsoft.EntityFrameworkCore;

namespace PortalAPI.Models.HR
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {           
        }
        public virtual DbSet<Main_Log_TicketingAPI> Main_Log_TicketingAPI { get; set; }
    }

}
