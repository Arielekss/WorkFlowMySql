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
        public TicketModel MapTicket2TicketModel(WebTicket ticket)
        {
            return new TicketModel()
            {
                Header = ticket.Header,
                Priority = ticket.Priority,
                RegisterDate = ticket.RegisterDate,
                UserRegister = ticket.UserRegister,
                TicketId = ticket.TicketId,
                ActiveUser = ticket.ActiveUser,
                Deadline = ticket.Deadline,
                CloseDate = ticket.CloseDate,
                Guid = ticket.Guid
            };
        }

        public List<WebTicket> MapTicketModelList2TicketList(List<TicketModel> ticket)
        {
            List<WebTicket> ticketList = new List<WebTicket>();
            foreach (TicketModel ticketModel in ticket)
            {
                ticketList.Add(new WebTicket()
                {
                    Header = ticketModel.Header,
                    Priority = ticketModel.Priority,
                    RegisterDate = ticketModel.RegisterDate,
                    UserRegister = ticketModel.UserRegister,
                    TicketId = ticketModel.TicketId,
                    ActiveUser = ticketModel.ActiveUser,
                    Deadline = ticketModel.Deadline,
                    CloseDate = ticketModel.CloseDate,
                    Guid = ticketModel.Guid
                });
            }
            return ticketList;
        }

        public WebTicketContent MapWebTicketContent2TicketModelContent(TicketBody ticketBody)
        {
            return new WebTicketContent()
            {
                TicketGuid = ticketBody.TicketGuid,
                Response = ticketBody.Response,
                Id = ticketBody.Id,
                Content = ticketBody.Content
            };
        }

        public TicketBody MapTicketBody2WebTicketContent(WebTicketContent webTicketContent)
        {
            return new TicketBody()
            {
                TicketGuid = webTicketContent.TicketGuid,
                Response = webTicketContent.Response,
                Id = webTicketContent.Id,
                Content = webTicketContent.Content
            };
        }
    }
}