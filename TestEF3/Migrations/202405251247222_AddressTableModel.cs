namespace TestEF3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressTableModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        AddressName = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenderId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        StaffName = c.String(),
                        StaffPhone = c.String(),
                        StaffSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddressId_AddressId = c.Int(),
                        GenderId_GenderId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Addresses", t => t.AddressId_AddressId)
                .ForeignKey("dbo.Genders", t => t.GenderId_GenderId)
                .Index(t => t.AddressId_AddressId)
                .Index(t => t.GenderId_GenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "GenderId_GenderId", "dbo.Genders");
            DropForeignKey("dbo.Staffs", "AddressId_AddressId", "dbo.Addresses");
            DropIndex("dbo.Staffs", new[] { "GenderId_GenderId" });
            DropIndex("dbo.Staffs", new[] { "AddressId_AddressId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Genders");
            DropTable("dbo.Addresses");
        }
    }
}
