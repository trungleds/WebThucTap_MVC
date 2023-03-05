namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chuxe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChuXes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        HoTen = c.String(maxLength: 250),
                        DienThoai = c.String(maxLength: 50),
                        CCCD = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 250),
                        DienDan = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChuXes");
        }
    }
}
