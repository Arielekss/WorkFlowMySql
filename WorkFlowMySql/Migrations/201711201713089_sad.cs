namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketModels", "Response", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TicketModels", "Response");
        }
    }
}
