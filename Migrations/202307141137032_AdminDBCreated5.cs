namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminDBCreated5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Admins", name: "ResId", newName: "Id");
            RenameIndex(table: "dbo.Admins", name: "IX_ResId", newName: "IX_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Admins", name: "IX_Id", newName: "IX_ResId");
            RenameColumn(table: "dbo.Admins", name: "Id", newName: "ResId");
        }
    }
}
