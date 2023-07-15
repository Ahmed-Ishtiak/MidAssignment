namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminDBCreated2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins");
            DropIndex("dbo.Restuarents", new[] { "Admin_AId" });
            DropColumn("dbo.Admins", "Status");
            DropColumn("dbo.Restuarents", "Admin_AId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restuarents", "Admin_AId", c => c.Int());
            AddColumn("dbo.Admins", "Status", c => c.String());
            CreateIndex("dbo.Restuarents", "Admin_AId");
            AddForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins", "AId");
        }
    }
}
