namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bang : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BangGiaVanTais", "NgayTao", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BangKeHoachVanTais", "NgayLapKH", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BangKeHoachVanTais", "NgayNhan", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BangKeHoachVanTais", "NgayGiaoHang", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BangKeHoachVanTais", "NgayTao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BangKeHoachVanTais", "NgayTao", c => c.DateTime());
            AlterColumn("dbo.BangKeHoachVanTais", "NgayGiaoHang", c => c.DateTime());
            AlterColumn("dbo.BangKeHoachVanTais", "NgayNhan", c => c.DateTime());
            AlterColumn("dbo.BangKeHoachVanTais", "NgayLapKH", c => c.DateTime());
            AlterColumn("dbo.BangGiaVanTais", "NgayTao", c => c.DateTime());
        }
    }
}
