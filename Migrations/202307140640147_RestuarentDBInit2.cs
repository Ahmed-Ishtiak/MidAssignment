namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restuarents", "AdminId", c => c.Int(nullable: false));
            AddColumn("dbo.Restuarents", "Admin_AId", c => c.Int());
            CreateIndex("dbo.Restuarents", "Admin_AId");
            AddForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins", "AId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins");
            DropIndex("dbo.Restuarents", new[] { "Admin_AId" });
            DropColumn("dbo.Restuarents", "Admin_AId");
            DropColumn("dbo.Restuarents", "AdminId");
        }
    }
}
