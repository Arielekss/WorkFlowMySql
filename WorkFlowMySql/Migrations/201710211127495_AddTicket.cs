namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTicket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketModels",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Header = c.String(unicode: false),
                        Content = c.String(unicode: false),
                        UserRegister = c.String(unicode: false),
                        ActiveUser = c.String(unicode: false),
                        RegisterDate = c.DateTime(nullable: false, precision: 0),
                        CloseDate = c.DateTime(precision: 0),
                        Priority = c.String(unicode: false),
                        Deadline = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketModels");
        }
    }
}
