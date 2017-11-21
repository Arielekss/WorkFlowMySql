namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sad1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TicketModels", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketModels", "Content", c => c.String(unicode: false));
        }
    }
}
