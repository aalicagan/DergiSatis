namespace Dergi.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboneDergiUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AboneDergis", "IslemDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AboneDergis", "IslemDate");
        }
    }
}
