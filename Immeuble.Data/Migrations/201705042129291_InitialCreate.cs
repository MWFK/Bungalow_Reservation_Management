namespace Immeuble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bungalows",
                c => new
                    {
                        CodeBungalow = c.Int(nullable: false, identity: true),
                        PrixChambre = c.Single(nullable: false),
                        NombreChambre = c.Int(nullable: false),
                        Descriptif = c.String(),
                        Adresse_CodePostal = c.Int(),
                    })
                .PrimaryKey(t => t.CodeBungalow)
                .ForeignKey("dbo.Adresses", t => t.Adresse_CodePostal)
                .Index(t => t.Adresse_CodePostal);
            
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        CodePostal = c.Int(nullable: false, identity: true),
                        Ville = c.String(),
                        Rue = c.String(),
                    })
                .PrimaryKey(t => t.CodePostal);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        CodeOption = c.Int(nullable: false, identity: true),
                        Commodite = c.Int(nullable: false),
                        PrixOption = c.Single(nullable: false),
                        BungalowFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodeOption)
                .ForeignKey("dbo.Bungalows", t => t.BungalowFK, cascadeDelete: true)
                .Index(t => t.BungalowFK);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        CodeBungalow = c.Int(nullable: false),
                        CIN = c.Int(nullable: false),
                        DateDebut = c.DateTime(nullable: false),
                        NombreJour = c.Int(nullable: false),
                        PrixTotal = c.Single(nullable: false),
                        Saison = c.Int(nullable: false),
                        Locataire_CIN = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CodeBungalow, t.CIN, t.DateDebut })
                .ForeignKey("dbo.Bungalows", t => t.CodeBungalow, cascadeDelete: true)
                .ForeignKey("dbo.Locataires", t => t.Locataire_CIN)
                .Index(t => t.CodeBungalow)
                .Index(t => t.Locataire_CIN);
            
            CreateTable(
                "dbo.Locataires",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 128),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Telephone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CIN);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Locataire_CIN", "dbo.Locataires");
            DropForeignKey("dbo.Reservations", "CodeBungalow", "dbo.Bungalows");
            DropForeignKey("dbo.Options", "BungalowFK", "dbo.Bungalows");
            DropForeignKey("dbo.Bungalows", "Adresse_CodePostal", "dbo.Adresses");
            DropIndex("dbo.Reservations", new[] { "Locataire_CIN" });
            DropIndex("dbo.Reservations", new[] { "CodeBungalow" });
            DropIndex("dbo.Options", new[] { "BungalowFK" });
            DropIndex("dbo.Bungalows", new[] { "Adresse_CodePostal" });
            DropTable("dbo.Locataires");
            DropTable("dbo.Reservations");
            DropTable("dbo.Options");
            DropTable("dbo.Adresses");
            DropTable("dbo.Bungalows");
        }
    }
}
