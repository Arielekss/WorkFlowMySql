using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;

namespace WorkFlowMySql.BLL
{
    public class TicketViewMethods
    {
        public List<TicketHeader> GetTicketList()
        {
            using (var context = new WorkFlowContext())
            {
                return context.Ticket.ToList();
            }
        }

        public List<TicketHeader> GetTicketListByUser(string user)
        {
            using (var context = new WorkFlowContext())
            {
                return context.Ticket.Where(s => s.UserRegister == user).ToList();
            }
        }

        public TicketHeader GeTicketHeaderById(int ticketId)
        {
            using (var context = new WorkFlowContext())
            {
                return context.Ticket.Where(s => s.TicketId == ticketId).ToList().FirstOrDefault();
            }
        }

        public TicketBody GeTicketBodyById(string guid)
        {
            using (var context = new WorkFlowContext())
            {
                return context.TicketBody.Where(s => s.TicketGuid == guid).ToList().FirstOrDefault();
            }
        }
    }
}
