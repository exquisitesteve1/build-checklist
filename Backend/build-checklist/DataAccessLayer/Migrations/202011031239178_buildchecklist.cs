namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buildchecklist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conversions",
                c => new
                    {
                        ConversionId = c.Int(nullable: false, identity: true),
                        ConversionName = c.String(nullable: false, maxLength: 255),
                        ConversionDescription = c.String(nullable: false, maxLength: 255),
                        IdMember1 = c.Int(nullable: false),
                        IdMember2 = c.Int(nullable: false),
                        IdMember3 = c.Int(nullable: false),
                        IdMember4 = c.Int(nullable: false),
                        CompletedStatus = c.Boolean(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ConversionId);
            
            CreateTable(
                "dbo.ITLs",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        ConversionId = c.Int(nullable: false),
                        TaskName = c.String(nullable: false, maxLength: 255),
                        TaskDescription = c.String(maxLength: 255),
                        CompletedStatus = c.Boolean(nullable: false),
                        StepNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId);
            
            CreateTable(
                "dbo.Lives",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        ConversionId = c.Int(nullable: false),
                        TaskName = c.String(nullable: false, maxLength: 255),
                        TaskDescription = c.String(maxLength: 255),
                        CompletedStatus = c.Boolean(nullable: false),
                        StepNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId);
            
            CreateTable(
                "dbo.SBs",
                c => new
                    {
                        EntryId = c.Int(nullable: false, identity: true),
                        ConversionId = c.Int(nullable: false),
                        TaskName = c.String(nullable: false, maxLength: 255),
                        TaskDescription = c.String(maxLength: 255),
                        CompletedStatus = c.Boolean(nullable: false),
                        StepNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        Lead = c.Boolean(nullable: false),
                        Admin = c.Boolean(nullable: false),
                        role = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.SBs");
            DropTable("dbo.Lives");
            DropTable("dbo.ITLs");
            DropTable("dbo.Conversions");
        }
    }
}
