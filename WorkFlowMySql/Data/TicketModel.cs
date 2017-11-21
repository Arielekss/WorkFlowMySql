using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data
{
    public class TicketModel
    {
        [Key]
        public int TicketId { get; set; }
        public string Header { get; set; }
        public string UserRegister { get; set; }
        public string ActiveUser { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Priority { get; set; }
        public DateTime Deadline { get; set; }
        public string Guid { get; set; }
    }
}
