namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDBCreated1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "Id", "dbo.Restuarents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Id", "dbo.Restuarents");
            DropIndex("dbo.Employees", new[] { "Id" });
            DropColumn("dbo.Employees", "Id");
        }
    }
}
