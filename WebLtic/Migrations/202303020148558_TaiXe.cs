namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaiXe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaiXes", "NgayCap", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaiXes", "NgayCap", c => c.DateTime(nullable: false));
        }
    }
}
