namespace MAP_PI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class longlat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "lang", c => c.String());
            AddColumn("dbo.AspNetUsers", "lat", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "lat");
            DropColumn("dbo.AspNetUsers", "lang");
        }
    }
}
