namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddViewingTimeToViewingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Viewings", "BookingTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Viewings", "BookingTime");
        }
    }
}
