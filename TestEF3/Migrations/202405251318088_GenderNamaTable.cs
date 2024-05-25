namespace TestEF3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderNamaTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genders", "GenderName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genders", "GenderName", c => c.Int(nullable: false));
        }
    }
}
