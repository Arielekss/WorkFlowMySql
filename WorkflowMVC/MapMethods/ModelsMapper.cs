using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkflowMVC.Models;
using WorkFlowMySql.Data;

namespace WorkflowMVC.MapMethods
{
    public class ModelsMapper
    {
        public TicketModel MapTicket2TicketModel(Ticket ticket)
        {
            return new TicketModel()
            {
                Header = ticket.Header,
                Content = ticket.Content,
                Priority = ticket.Priority,
                RegisterDate = ticket.RegisterDate,
                UserRegister = ticket.UserRegister,
                TicketId = ticket.TicketId,
                ActiveUser = ticket.ActiveUser,
                Deadline = ticket.Deadline,
                CloseDate = ticket.CloseDate
            };
        }

        public List<Ticket> MapTicketModelList2TicketList(List<TicketModel> ticket)
        {
            List<Ticket> ticketList = new List<Ticket>();
            foreach (TicketModel ticketModel in ticket)
            {
                ticketList.Add(new Ticket()
                {
                    Header = ticketModel.Header,
                    Content = ticketModel.Content,
                    Priority = ticketModel.Priority,
                    RegisterDate = ticketModel.RegisterDate,
                    UserRegister = ticketModel.UserRegister,
                    TicketId = ticketModel.TicketId,
                    ActiveUser = ticketModel.ActiveUser,
                    Deadline = ticketModel.Deadline,
                    CloseDate = ticketModel.CloseDate
                });
            }
            return ticketList;
        }
    }
}