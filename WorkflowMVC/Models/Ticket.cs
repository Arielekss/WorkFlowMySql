using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkflowMVC.Models
{
    public class Ticket
    {
            [Key]
            public int TicketId { get; set; }
            public string Header { get; set; }
            public string Content { get; set; }
            public string UserRegister { get; set; }
            public string ActiveUser { get; set; }
            public DateTime RegisterDate { get; set; }
            public DateTime? CloseDate { get; set; }
            public string Priority { get; set; }
            public DateTime Deadline { get; set; }
        public string Response { get; set; }
        
    }
}