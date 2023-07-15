namespace MidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestuarentDBInit1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Restuarents", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Restuarents", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Restuarents", "MaxTime", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Restuarents", "MaxTime", c => c.String(nullable: false));
            AlterColumn("dbo.Restuarents", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Restuarents", "Name", c => c.String(nullable: false));
        }
    }
}
