namespace Dergi.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboneDergis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboneId = c.Int(nullable: false),
                        DergiId = c.Int(nullable: false),
                        IsDelivered = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abones", t => t.AboneId, cascadeDelete: true)
                .ForeignKey("dbo.Dergis", t => t.DergiId, cascadeDelete: true)
                .Index(t => t.AboneId)
                .Index(t => t.DergiId);
            
            CreateTable(
                "dbo.Abones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Surname = c.String(maxLength: 4000),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        BirimId = c.Int(nullable: false),
                        Description = c.String(maxLength: 4000),
                        Count = c.Int(nullable: false),
                        FirstDergiId = c.Int(nullable: false),
                        LastDergiId = c.Int(nullable: false),
                        AboneTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AboneTypes", t => t.AboneTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Birims", t => t.BirimId, cascadeDelete: true)
                .Index(t => t.BirimId)
                .Index(t => t.AboneTypeId);
            
            CreateTable(
                "dbo.AboneTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DergiCount = c.Int(nullable: false),
                        IsFree = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Birims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Status = c.Int(nullable: false),
                        BolgeId = c.Int(nullable: false),
                        BirimTurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BirimTurs", t => t.BirimTurId, cascadeDelete: true)
                .ForeignKey("dbo.Bolges", t => t.BolgeId, cascadeDelete: true)
                .Index(t => t.BolgeId)
                .Index(t => t.BirimTurId);
            
            CreateTable(
                "dbo.BirimTurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bolges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dergis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        Year = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AboneHesaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AboneId = c.Int(nullable: false),
                        IslemType = c.Int(nullable: false),
                        IslemDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abones", t => t.AboneId, cascadeDelete: true)
                .Index(t => t.AboneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AboneHesaps", "AboneId", "dbo.Abones");
            DropForeignKey("dbo.AboneDergis", "DergiId", "dbo.Dergis");
            DropForeignKey("dbo.AboneDergis", "AboneId", "dbo.Abones");
            DropForeignKey("dbo.Abones", "BirimId", "dbo.Birims");
            DropForeignKey("dbo.Birims", "BolgeId", "dbo.Bolges");
            DropForeignKey("dbo.Birims", "BirimTurId", "dbo.BirimTurs");
            DropForeignKey("dbo.Abones", "AboneTypeId", "dbo.AboneTypes");
            DropIndex("dbo.AboneHesaps", new[] { "AboneId" });
            DropIndex("dbo.Birims", new[] { "BirimTurId" });
            DropIndex("dbo.Birims", new[] { "BolgeId" });
            DropIndex("dbo.Abones", new[] { "AboneTypeId" });
            DropIndex("dbo.Abones", new[] { "BirimId" });
            DropIndex("dbo.AboneDergis", new[] { "DergiId" });
            DropIndex("dbo.AboneDergis", new[] { "AboneId" });
            DropTable("dbo.AboneHesaps");
            DropTable("dbo.Dergis");
            DropTable("dbo.Bolges");
            DropTable("dbo.BirimTurs");
            DropTable("dbo.Birims");
            DropTable("dbo.AboneTypes");
            DropTable("dbo.Abones");
            DropTable("dbo.AboneDergis");
        }
    }
}
