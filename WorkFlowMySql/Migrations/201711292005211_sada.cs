namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Commentaries",
                c => new
                    {
                        CommentaryId = c.Int(nullable: false, identity: true),
                        TicketGuid = c.String(unicode: false),
                        UserId = c.Int(nullable: false),
                        CommentaryContent = c.String(unicode: false),
                        CommentaryDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.CommentaryId)                ;
            
            AddColumn("TicketHeaders", "ActiveUserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("TicketHeaders", "ActiveUserId");
            DropTable("Commentaries");
        }
    }
}
