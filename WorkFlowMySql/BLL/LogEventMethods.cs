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
            switch (eventEnum)
            {
                case EventEnum.CreateTicket:
                    eventType = "CreateTicket";
                    break;
                case EventEnum.CancelTicket:
                    eventType = "CancelTicket";
                    break;
                case EventEnum.AddComment:
                    eventType = "AddComment";
                    break;
                case EventEnum.CloseTicket:
                    eventType = "CloseTicket";
                    break;
                case EventEnum.MoveToNextUser:
                    eventType = "MoveToNextUser";
                    break;
                default:
                    eventType = "Unknown";
                    break;
            }
            return new EventLog()
            {
                Guid = ticketHeader.Guid,
                EvenDate = DateTime.Now,
                User = ticketHeader.UserRegister,
                EventType = eventType
            };
        }
    }
}
