namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EId);
            
            AddColumn("dbo.Restuarents", "Employee_EId", c => c.Int());
            CreateIndex("dbo.Restuarents", "Employee_EId");
            AddForeignKey("dbo.Restuarents", "Employee_EId", "dbo.Employees", "EId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restuarents", "Employee_EId", "dbo.Employees");
            DropIndex("dbo.Restuarents", new[] { "Employee_EId" });
            DropColumn("dbo.Restuarents", "Employee_EId");
            DropTable("dbo.Employees");
        }
    }
}
