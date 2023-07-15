namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Status", c => c.String());
            AddColumn("dbo.Restuarents", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restuarents", "Status");
            DropColumn("dbo.Admins", "Status");
        }
    }
}
