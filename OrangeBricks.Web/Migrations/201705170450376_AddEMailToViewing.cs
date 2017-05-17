namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEMailToViewing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewings", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Viewings", "Email");
        }
    }
}
