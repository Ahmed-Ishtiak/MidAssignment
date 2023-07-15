namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminDBCreated4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Admins", "Restuarent_Id", "dbo.Restuarents");
            DropIndex("dbo.Admins", new[] { "Restuarent_Id" });
            RenameColumn(table: "dbo.Admins", name: "Restuarent_Id", newName: "ResId");
            AlterColumn("dbo.Admins", "ResId", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "ResId");
            AddForeignKey("dbo.Admins", "ResId", "dbo.Restuarents", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "ResId", "dbo.Restuarents");
            DropIndex("dbo.Admins", new[] { "ResId" });
            AlterColumn("dbo.Admins", "ResId", c => c.Int());
            RenameColumn(table: "dbo.Admins", name: "ResId", newName: "Restuarent_Id");
            CreateIndex("dbo.Admins", "Restuarent_Id");
            AddForeignKey("dbo.Admins", "Restuarent_Id", "dbo.Restuarents", "Id");
        }
    }
}
