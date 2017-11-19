namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asda : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserModels", "UserName", c => c.String());
            AlterColumn("dbo.UserModels", "Pass", c => c.String());
            AlterColumn("dbo.UserModels", "UserType", c => c.String());
            AlterColumn("dbo.TicketModels", "Header", c => c.String());
            AlterColumn("dbo.TicketModels", "Content", c => c.String());
            AlterColumn("dbo.TicketModels", "UserRegister", c => c.String());
            AlterColumn("dbo.TicketModels", "ActiveUser", c => c.String());
            AlterColumn("dbo.TicketModels", "RegisterDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TicketModels", "CloseDate", c => c.DateTime());
            AlterColumn("dbo.TicketModels", "Priority", c => c.String());
            AlterColumn("dbo.TicketModels", "Deadline", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TicketModels", "Deadline", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.TicketModels", "Priority", c => c.String(unicode: false));
            AlterColumn("dbo.TicketModels", "CloseDate", c => c.DateTime(precision: 0));
            AlterColumn("dbo.TicketModels", "RegisterDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.TicketModels", "ActiveUser", c => c.String(unicode: false));
            AlterColumn("dbo.TicketModels", "UserRegister", c => c.String(unicode: false));
            AlterColumn("dbo.TicketModels", "Content", c => c.String(unicode: false));
            AlterColumn("dbo.TicketModels", "Header", c => c.String(unicode: false));
            AlterColumn("dbo.UserModels", "UserType", c => c.String(unicode: false));
            AlterColumn("dbo.UserModels", "Pass", c => c.String(unicode: false));
            AlterColumn("dbo.UserModels", "UserName", c => c.String(unicode: false));
        }
    }
}
