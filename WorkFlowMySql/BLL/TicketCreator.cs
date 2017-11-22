using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.Data;
using WorkFlowMySql.Data.Enums;

namespace WorkFlowMySql.BLL
{
    public class TicketCreator
    {
        LogEventMethods log = new LogEventMethods();
        
        public DateTime CalculateDeadline(string priority)
        {
            DateTime deadline = DateTime.Now;

            if (priority == "Normal")
                deadline = DateTime.Now.AddDays(3);
            
            else if (priority == "Critical")
                deadline = DateTime.Now.AddHours(8);

            return deadline;
        }
        public void SendTicketToDb( TicketHeader ticketHeader, TicketBody ticketBody)
        {
            using (var context = new WorkFlowContext())
            {
                string guid = Guid.NewGuid().ToString();
                if (ticketHeader.Priority == null)
                    ticketHeader.Deadline = CalculateDeadline(ticketHeader.Priority);
                
                ticketHeader.Guid = guid;
                ticketHeader.Status = "Active";
                ticketBody.TicketGuid = guid;
                ticketHeader.ActiveUser = ticketHeader.UserRegister;
                context.Ticket.Add(ticketHeader);
                context.TicketBody.Add(ticketBody);
                context.EventLogContext.Add(log.CreatEventLog(ticketHeader, EventEnum.CreateTicket));
                context.SaveChanges();
            }
        }
    }
}

