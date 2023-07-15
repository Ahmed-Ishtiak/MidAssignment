namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminDBCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AId);
            
            AddColumn("dbo.Restuarents", "Admin_AId", c => c.Int());
            CreateIndex("dbo.Restuarents", "Admin_AId");
            AddForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins", "AId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restuarents", "Admin_AId", "dbo.Admins");
            DropIndex("dbo.Restuarents", new[] { "Admin_AId" });
            DropColumn("dbo.Restuarents", "Admin_AId");
            DropTable("dbo.Admins");
        }
    }
}
