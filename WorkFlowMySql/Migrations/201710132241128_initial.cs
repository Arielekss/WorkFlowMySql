namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(unicode: false),
                        Pass = c.String(unicode: false),
                        UserType = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
