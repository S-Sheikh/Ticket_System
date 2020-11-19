using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ticket_system_api.Data
{
    public class ticketContext : DbContext
    {
        public ticketContext (DbContextOptions<ticketContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}
