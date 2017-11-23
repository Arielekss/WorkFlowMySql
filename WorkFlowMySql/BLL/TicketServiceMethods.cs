using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;
using WorkFlowMySql.Data.Enums;

namespace WorkFlowMySql.BLL
{
    public class TicketServiceMethods
    {
        LogEventMethods log = new LogEventMethods();
        public void UpdateTicketStatusById(int ticketId, string ticketStatus, string response)
        {
            using (var context = new WorkFlowContext())
            {
               var ticket = context.Ticket.Where(s => s.TicketId == ticketId).ToList().FirstOrDefault();
                ticket.Status = ticketStatus;
                ticket.CloseDate = DateTime.Now;
                context.Ticket.AddOrUpdate(ticket);

                if (ticketStatus == "Cancel")
                    context.EventLogContext.Add(log.CreatEventLog(ticket, EventEnum.CancelTicket));

                else if (ticketStatus == "Close")
                {
                    var ticketBody = context.TicketBody.Where(s => s.TicketGuid == ticket.Guid).ToList().FirstOrDefault();
                    ticketBody.Response = response;
                    context.TicketBody.AddOrUpdate(ticketBody);
                    context.EventLogContext.Add(log.CreatEventLog(ticket, EventEnum.CloseTicket));
                }
                context.SaveChanges();
            }
        }
        public void UpdateTicketResponseById()
        {

        }
    }
}
