using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkflowMVC.Models
{
    public class WebUserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}