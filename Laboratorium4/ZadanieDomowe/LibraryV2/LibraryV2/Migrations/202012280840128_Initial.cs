namespace LibraryV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonName = c.String(maxLength: 64),
                        Title = c.String(nullable: false, maxLength: 64),
                        AuthorsId = c.Int(nullable: false),
                        GenresId = c.Int(nullable: false),
                        StatesId = c.Int(nullable: false),
                        RestrictionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorsId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenresId, cascadeDelete: true)
                .ForeignKey("dbo.Restrictions", t => t.RestrictionsId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StatesId, cascadeDelete: true)
                .Index(t => t.AuthorsId)
                .Index(t => t.GenresId)
                .Index(t => t.StatesId)
                .Index(t => t.RestrictionsId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Restrictions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgeLimit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rental = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Identities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        Age = c.Int(nullable: false),
                        Image = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 64),
                        Password = c.String(nullable: false, maxLength: 64),
                        IdentitiesId = c.Int(nullable: false),
                        RolesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Identities", t => t.IdentitiesId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RolesId, cascadeDelete: true)
                .Index(t => t.IdentitiesId)
                .Index(t => t.RolesId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RolesId", "dbo.Roles");
            DropForeignKey("dbo.Users", "IdentitiesId", "dbo.Identities");
            DropForeignKey("dbo.Books", "StatesId", "dbo.States");
            DropForeignKey("dbo.Books", "RestrictionsId", "dbo.Restrictions");
            DropForeignKey("dbo.Books", "GenresId", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorsId", "dbo.Authors");
            DropIndex("dbo.Users", new[] { "RolesId" });
            DropIndex("dbo.Users", new[] { "IdentitiesId" });
            DropIndex("dbo.Books", new[] { "RestrictionsId" });
            DropIndex("dbo.Books", new[] { "StatesId" });
            DropIndex("dbo.Books", new[] { "GenresId" });
            DropIndex("dbo.Books", new[] { "AuthorsId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Identities");
            DropTable("dbo.States");
            DropTable("dbo.Restrictions");
            DropTable("dbo.Genres");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
