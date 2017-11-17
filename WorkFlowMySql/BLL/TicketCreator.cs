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
        public void SendTicketToDb( TicketModel ticketModel)
        {
            using (var context = new WorkFlowContext())
            {
                context.Ticket.Add(ticketModel);
                context.SaveChanges();
                MessageBox.Show("Ticket was send");
            }
        }
    }
}

