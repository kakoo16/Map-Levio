namespace MAP_PI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class j : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Mandates");
            AddPrimaryKey("dbo.Mandates", new[] { "ProjectId", "Id", "start_Date", "end_Date" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Mandates");
            AddPrimaryKey("dbo.Mandates", new[] { "Id", "start_Date", "end_Date" });
        }
    }
}
