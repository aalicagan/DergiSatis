namespace Dergi.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dergiUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Dergis", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dergis", "Status", c => c.Int(nullable: false));
        }
    }
}
