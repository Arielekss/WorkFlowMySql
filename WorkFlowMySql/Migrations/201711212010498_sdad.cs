namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketContents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketGuid = c.String(unicode: false),
                        Content = c.String(unicode: false),
                        Response = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TicketContents");
        }
    }
}
