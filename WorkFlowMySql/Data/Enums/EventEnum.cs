using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data.Enums
{
    public enum EventEnum
    {
        none,
        CreateTicket,
        CloseTicket,
        AddComment,
        CancelTicket,
        MoveToNextUser
    }
}
