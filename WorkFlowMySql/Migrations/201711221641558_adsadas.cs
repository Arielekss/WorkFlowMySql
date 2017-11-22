namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adsadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "UserModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(unicode: false),
                        Pass = c.String(unicode: false),
                        UserType = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.UserId)                ;
            
            CreateTable(
                "EventLogs",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        EventType = c.String(unicode: false),
                        EvenDate = c.DateTime(nullable: false, precision: 0),
                        User = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EventId)                ;
            
            CreateTable(
                "TicketHeaders",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Header = c.String(unicode: false),
                        UserRegister = c.String(unicode: false),
                        ActiveUser = c.String(unicode: false),
                        RegisterDate = c.DateTime(nullable: false, precision: 0),
                        CloseDate = c.DateTime(precision: 0),
                        Priority = c.String(unicode: false),
                        Deadline = c.DateTime(nullable: false, precision: 0),
                        Guid = c.String(unicode: false),
                        Status = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TicketId)                ;
            
            CreateTable(
                "TicketBodies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketGuid = c.String(unicode: false),
                        Content = c.String(unicode: false),
                        Response = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)                ;
            
        }
        
        public override void Down()
        {
            DropTable("TicketBodies");
            DropTable("TicketHeaders");
            DropTable("EventLogs");
            DropTable("UserModels");
        }
    }
}
