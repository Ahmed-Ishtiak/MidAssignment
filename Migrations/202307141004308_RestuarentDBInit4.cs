namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restuarents", "AdminId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restuarents", "AdminId", c => c.Int(nullable: false));
        }
    }
}
