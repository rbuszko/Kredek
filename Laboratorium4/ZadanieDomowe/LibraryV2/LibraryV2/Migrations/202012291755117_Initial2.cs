namespace LibraryV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restrictions", "AgeLimit", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restrictions", "AgeLimit", c => c.Int(nullable: false));
        }
    }
}
