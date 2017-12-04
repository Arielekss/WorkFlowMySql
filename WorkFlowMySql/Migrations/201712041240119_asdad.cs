namespace WorkFlowMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("UserModels", "RegisterDate", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("UserModels", "RegisterDate", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
