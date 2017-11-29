using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data
{
    public class Commentary
    {
        public int CommentaryId { get; set; }
        public string TicketGuid { get; set; }
        public int UserId { get; set; }
        public string CommentaryContent { get; set; }
        public DateTime CommentaryDate { get; set; }
    }
}
