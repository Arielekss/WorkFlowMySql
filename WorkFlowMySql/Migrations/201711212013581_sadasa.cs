namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sadasa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TicketModels", "Guid", c => c.String(unicode: false));
            DropColumn("dbo.TicketModels", "Response");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TicketModels", "Response", c => c.String(unicode: false));
            DropColumn("dbo.TicketModels", "Guid");
        }
    }
}
