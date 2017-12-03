namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adsaas : DbMigration
    {
        public override void Up()
        {
            AddColumn("UserModels", "Email", c => c.String(unicode: false));
            AddColumn("UserModels", "RegisterDate", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("UserModels", "RegisterDate");
            DropColumn("UserModels", "Email");
        }
    }
}
