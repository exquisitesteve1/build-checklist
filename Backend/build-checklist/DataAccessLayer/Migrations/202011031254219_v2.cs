namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conversions", "ConversionDescription", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Conversions", "ConversionDescription", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
