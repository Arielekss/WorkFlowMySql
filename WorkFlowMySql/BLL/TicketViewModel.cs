using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL
{
    public class TicketViewModel
    {
        public List<TicketModel> GetTicketList()
        {
            using (var context = new WorkFlowContext())
            {
                return context.Ticket.ToList();
            }
        }
    }
}
