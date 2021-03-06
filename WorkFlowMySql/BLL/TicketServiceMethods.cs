﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;
using WorkFlowMySql.Data.Enums;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql.BLL
{
    public class TicketServiceMethods
    {
        LogEventMethods log = new LogEventMethods();

        private WorkFlowContext _context;

        public TicketServiceMethods(WorkFlowContext context)
        {
            _context = context;
        }
        public TicketServiceMethods()
        {
            _context = new WorkFlowContext();
        }

        public void UpdateTicketStatusById(int ticketId, string ticketStatus, string response)
        {
           
               var ticket = _context.Ticket.Where(s => s.TicketId == ticketId).ToList().FirstOrDefault();
                ticket.Status = ticketStatus;
                ticket.CloseDate = DateTime.Now;
                _context.Ticket.AddOrUpdate(ticket);

                if (ticketStatus == "Cancel")
                    _context.EventLogContext.Add(log.CreatEventLog(ticket, EventEnum.CancelTicket));

                else if (ticketStatus == "Close")
                {
                    var ticketBody = _context.TicketBody.Where(s => s.TicketGuid == ticket.Guid).ToList().FirstOrDefault();
                    ticketBody.Response = response;
                    _context.TicketBody.AddOrUpdate(ticketBody);
                    _context.EventLogContext.Add(log.CreatEventLog(ticket, EventEnum.CloseTicket));
                }
                _context.SaveChanges();
            
        }
        public void UpdateTicketResponseById()
        {
            //TODO:
        }

        public void MoveTicketToAnotherUser(TicketHeader ticketHeader ,UserModel selectedUser)
        {
            using (var context = new WorkFlowContext())
            {
                var ticket = context.Ticket.Where(s => s.TicketId == ticketHeader.TicketId).ToList().FirstOrDefault();
                ticket.ActiveUserId = selectedUser.UserId;
                ticket.ActiveUser = selectedUser.UserName;
                context.Ticket.AddOrUpdate(ticket);
                context.EventLogContext.Add(log.CreatEventLog(ticketHeader, EventEnum.MoveToNextUser));
                context.SaveChanges();
            }
        }

        public void AddComment(TicketHeader ticketHeader, string commentContent)
        {
            using (var context = new WorkFlowContext())
            {
                Commentary comment = new Commentary
                {
                    UserId = ticketHeader.ActiveUserId,
                    CommentaryContent = commentContent,
                    CommentaryDate = DateTime.Now,
                    TicketGuid = ticketHeader.Guid
                };
                context.CommentaryContext.Add(comment);
                context.EventLogContext.Add(log.CreatEventLog(ticketHeader, EventEnum.AddComment));
                context.SaveChanges();
            }
        }

    }
}
