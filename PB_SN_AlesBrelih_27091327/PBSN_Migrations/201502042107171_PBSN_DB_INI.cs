namespace PB_SN_AlesBrelih_27091327.PBSN_Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PBSN_DB_INI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Podjetjes",
                c => new
                    {
                        PodjetjeId = c.Int(nullable: false, identity: true),
                        ImePodjetja = c.String(nullable: false),
                        KontaktnaOseba_OsebaID = c.Int(),
                    })
                .PrimaryKey(t => t.PodjetjeId)
                .ForeignKey("dbo.Osebas", t => t.KontaktnaOseba_OsebaID)
                .Index(t => t.KontaktnaOseba_OsebaID);
            
            CreateTable(
                "dbo.Osebas",
                c => new
                    {
                        OsebaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Priimek = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.OsebaID);
            
            CreateTable(
                "dbo.Najems",
                c => new
                    {
                        NajemID = c.Int(nullable: false, identity: true),
                        ZacetekNajema = c.DateTime(nullable: false),
                        KonecNajema = c.DateTime(nullable: false),
                        Podjetje_PodjetjeId = c.Int(),
                        PoslovniProstor_PoslovniProstorID = c.Int(),
                    })
                .PrimaryKey(t => t.NajemID)
                .ForeignKey("dbo.Podjetjes", t => t.Podjetje_PodjetjeId)
                .ForeignKey("dbo.PoslovniProstors", t => t.PoslovniProstor_PoslovniProstorID)
                .Index(t => t.Podjetje_PodjetjeId)
                .Index(t => t.PoslovniProstor_PoslovniProstorID);
            
            CreateTable(
                "dbo.PoslovniProstors",
                c => new
                    {
                        PoslovniProstorID = c.Int(nullable: false, identity: true),
                        ImeProstora = c.String(nullable: false),
                        DnevnaCena = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoslovniProstorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Najems", "PoslovniProstor_PoslovniProstorID", "dbo.PoslovniProstors");
            DropForeignKey("dbo.Najems", "Podjetje_PodjetjeId", "dbo.Podjetjes");
            DropForeignKey("dbo.Podjetjes", "KontaktnaOseba_OsebaID", "dbo.Osebas");
            DropIndex("dbo.Najems", new[] { "PoslovniProstor_PoslovniProstorID" });
            DropIndex("dbo.Najems", new[] { "Podjetje_PodjetjeId" });
            DropIndex("dbo.Podjetjes", new[] { "KontaktnaOseba_OsebaID" });
            DropTable("dbo.PoslovniProstors");
            DropTable("dbo.Najems");
            DropTable("dbo.Osebas");
            DropTable("dbo.Podjetjes");
        }
    }
}
