namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationToVideos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "classification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "classification");
        }
    }
}
