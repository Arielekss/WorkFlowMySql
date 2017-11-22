using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.BLL
{
    public class TicketServiceMethods
    {
        public void UpdateTicketStatusById(int ticketId, string ticketStatus)
        {
            using (var context = new WorkFlowContext())
            {
               var ticket = context.Ticket.Where(s => s.TicketId == ticketId).ToList().FirstOrDefault();
                ticket.Status = ticketStatus;
                context.Ticket.AddOrUpdate(ticket);
            }
        }
    }
}
