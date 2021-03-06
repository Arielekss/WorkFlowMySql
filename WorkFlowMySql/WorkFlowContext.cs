﻿using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkFlowMySql.Data;
using WorkFlowMySql.GUI;

namespace WorkFlowMySql
{
    public partial class WorkFlowContext : DbContext
    {
        public WorkFlowContext() : base(nameOrConnectionString: "WorkFlowContext") { }

        public DbSet<UserModel> Customer { get; set; }
        public virtual DbSet<TicketHeader> Ticket { get; set; }
        public DbSet<TicketBody> TicketBody { get; set; }
        public DbSet<EventLog> EventLogContext { get; set; }
        public DbSet<Commentary> CommentaryContext { get; set; }
    }




    /* // Code-Based Configuration and Dependency resolution  
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WorkFlowContext : DbContext
    {
        public WorkFlowContext() : base("WorkFlowContext")
   {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //Add your Dbsets here  
        public DbSet<UserModel> User
        {
            get;
            set;
        }

        /*public WorkFlowContext()
            //Reference the name of your connection string  
            : base("WorkFlowContext") { }
    }*/
}
