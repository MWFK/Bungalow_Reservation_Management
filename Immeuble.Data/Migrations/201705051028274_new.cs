namespace Immeuble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "DateDebut", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddPrimaryKey("dbo.Reservations", new[] { "CodeBungalow", "CIN", "DateDebut" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "DateDebut", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Reservations", new[] { "CodeBungalow", "CIN", "DateDebut" });
        }
    }
}
