namespace TestEF3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnitModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        UnitName = c.String(nullable: false),
                        UnitPrice = c.String(),
                    })
                .PrimaryKey(t => t.UnitId);
            
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Note", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Note", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            DropTable("dbo.Units");
        }
    }
}
