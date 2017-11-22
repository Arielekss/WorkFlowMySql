using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkflowMVC.Models
{
    public class WebTicketContent
    {
        public int Id { get; set; }
        public string TicketGuid { get; set; }
        public string Content { get; set; }
        public string Response { get; set; }
    }
}