using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data
{
    public class EventLog
    {
        [Key]
        public int EventId { get; set; }
        public int TicketId { get; set; }
        public string EventType { get; set; }
        public DateTime EvenDate { get; set; }
        public string User { get; set; }
    }
}
