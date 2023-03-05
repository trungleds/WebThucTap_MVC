namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tuyenduong2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TuyenDuongs", "HienThi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TuyenDuongs", "HienThi", c => c.Boolean());
        }
    }
}
