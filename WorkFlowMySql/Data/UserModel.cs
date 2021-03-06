﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowMySql.Data
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
