namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins");
            AddColumn("dbo.Admins", "Restuarent_Id", c => c.Int());
            AddColumn("dbo.Restuarents", "Admin_AId1", c => c.Int());
            CreateIndex("dbo.Admins", "Restuarent_Id");
            CreateIndex("dbo.Restuarents", "Admin_AId1");
            AddForeignKey("dbo.Admins", "Restuarent_Id", "dbo.Restuarents", "Id");
            AddForeignKey("dbo.Restuarents", "Admin_AId1", "dbo.Admins", "AId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restuarents", "Admin_AId1", "dbo.Admins");
            DropForeignKey("dbo.Admins", "Restuarent_Id", "dbo.Restuarents");
            DropIndex("dbo.Restuarents", new[] { "Admin_AId1" });
            DropIndex("dbo.Admins", new[] { "Restuarent_Id" });
            DropColumn("dbo.Restuarents", "Admin_AId1");
            DropColumn("dbo.Admins", "Restuarent_Id");
            AddForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins", "AId");
        }
    }
}
