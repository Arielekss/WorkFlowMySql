using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data
{
    public class TicketBody
    {
        [Key]
        public int Id { get; set; }
        public string TicketGuid { get; set; }
        public string Content { get; set; }
        public string Response { get; set; }
    }
}

