namespace TestEF3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StaffDataTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staffs", "StaffName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "StaffName", c => c.String(nullable: false));
        }
    }
}
