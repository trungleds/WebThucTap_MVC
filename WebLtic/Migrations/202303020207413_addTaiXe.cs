namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTaiXe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaiXes", "NamSinh", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TaiXes", "NgayCap", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaiXes", "NgayCap", c => c.DateTime());
            AlterColumn("dbo.TaiXes", "NamSinh", c => c.DateTime());
        }
    }
}
