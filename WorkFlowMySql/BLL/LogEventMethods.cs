using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;
using WorkFlowMySql.Data.Enums;

namespace WorkFlowMySql.BLL
{
    public class LogEventMethods
    {
        public EventLog CreatEventLog(TicketHeader ticketHeader, EventEnum eventEnum)
        {
            string eventType = null;
            string user = null;
            switch (eventEnum)
            {
                case EventEnum.CreateTicket:
                    eventType = "CreateTicket";
                    user = ticketHeader.UserRegister;
                    break;
                case EventEnum.CancelTicket:
                    eventType = "CancelTicket";
                    user = ticketHeader.ActiveUser;
                    break;
                case EventEnum.AddComment:
                    eventType = "AddComment";
                    user = ticketHeader.ActiveUser;
                    break;
                case EventEnum.CloseTicket:
                    eventType = "CloseTicket";
                    user = ticketHeader.ActiveUser;
                    break;
                case EventEnum.MoveToNextUser:
                    eventType = "MoveToNextUser";
                    user = ticketHeader.ActiveUser;
                    break;
                default:
                    eventType = "Unknown";
                    user = ticketHeader.ActiveUser;
                    break;
            }
            return new EventLog()
            {
                Guid = ticketHeader.Guid,
                EvenDate = DateTime.Now,
                User = user,
                EventType = eventType
            };
        }
    }
}
