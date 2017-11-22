using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL
{
    public class TicketCreator
    {
        
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
                string guid = new Guid().ToString();
                if(ticketHeader.Priority == null)
                    ticketHeader.Deadline = CalculateDeadline(ticketHeader.Priority);

                ticketHeader.Guid = guid;
                ticketBody.TicketGuid = guid;
                context.Ticket.Add(ticketHeader);
                context.TicketBody.Add(ticketBody);
                context.SaveChanges();
            }
        }
    }
}

