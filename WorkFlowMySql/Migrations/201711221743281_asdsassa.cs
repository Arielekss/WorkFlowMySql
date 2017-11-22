namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdsassa : DbMigration
    {
        public override void Up()
        {
            AddColumn("EventLogs", "Guid", c => c.String(unicode: false));
            DropColumn("EventLogs", "TicketId");
        }
        
        public override void Down()
        {
            AddColumn("EventLogs", "TicketId", c => c.Int(nullable: false));
            DropColumn("EventLogs", "Guid");
        }
    }
}
