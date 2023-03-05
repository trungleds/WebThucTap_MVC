namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class them : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BangGiaVanTais",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        TenTuyenDuong = c.String(maxLength: 250),
                        TenHangHoa = c.String(maxLength: 50),
                        DVT = c.String(maxLength: 50),
                        DonGia = c.Decimal(precision: 18, scale: 2),
                        DienDan = c.String(maxLength: 250),
                        ChiNhanh = c.String(maxLength: 50),
                        NgayTao = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BangKeHoachVanTais",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        NgayLapKH = c.DateTime(),
                        KhachHang = c.String(maxLength: 50),
                        NgayNhan = c.DateTime(),
                        NoiNhanHang = c.String(maxLength: 150),
                        NgayGiaoHang = c.DateTime(),
                        NoiGiaoHang = c.String(maxLength: 150),
                        TenHang = c.String(maxLength: 150),
                        DVT = c.String(maxLength: 50),
                        SoLuong = c.String(maxLength: 50),
                        DonGia = c.Decimal(precision: 18, scale: 2),
                        ThanhTien = c.Decimal(precision: 18, scale: 2),
                        TienDaGiao = c.Decimal(precision: 18, scale: 2),
                        TienThieu = c.Decimal(precision: 18, scale: 2),
                        DienDan = c.String(maxLength: 250),
                        TinhTrang = c.Boolean(),
                        ThanhToan = c.Decimal(precision: 18, scale: 2),
                        TongBX = c.Decimal(precision: 18, scale: 2),
                        PhiPhatSinh = c.Decimal(precision: 18, scale: 2),
                        TongPhi = c.String(maxLength: 10),
                        BienSoXe = c.String(maxLength: 50),
                        ChuHang = c.String(maxLength: 50),
                        NgayTao = c.DateTime(),
                        NguoiTao = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DanhSachXes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        HienThi = c.Boolean(nullable: false),
                        TenXe = c.String(maxLength: 50),
                        BienSoXe = c.String(maxLength: 50),
                        LoaiXe = c.String(maxLength: 50),
                        ChuXe = c.String(maxLength: 250),
                        TaiXe = c.String(maxLength: 50),
                        MauSon = c.String(maxLength: 50),
                        HangXe = c.String(maxLength: 50),
                        GhiChu = c.String(maxLength: 250),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        HienThi = c.Boolean(),
                        TenHangHoa = c.String(maxLength: 50),
                        LoaiHangHoa = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        DoiTac = c.String(maxLength: 250),
                        DiaChi = c.String(maxLength: 250),
                        DienThoai = c.String(maxLength: 50),
                        NoBanDau = c.Decimal(precision: 18, scale: 2),
                        KhuVuc = c.String(maxLength: 250),
                        LoaiDoiTac = c.String(maxLength: 50),
                        CCCD = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TaiXes",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        HienThi = c.Boolean(nullable: false),
                        HoTen = c.String(maxLength: 250),
                        BienSoXe = c.String(maxLength: 50),
                        DienThoai = c.String(maxLength: 50),
                        NamSinh = c.DateTime(),
                        CCCD = c.String(maxLength: 50),
                        NgayCap = c.DateTime(),
                        NoiCap = c.String(maxLength: 250),
                        DiaChi = c.String(maxLength: 250),
                        LuongCB = c.Decimal(precision: 18, scale: 2),
                        GiayTo = c.String(maxLength: 250),
                        DienDan = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TuyenDuongs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        HienThi = c.Boolean(),
                        MaTuyen = c.String(maxLength: 50),
                        TenTuyenDuong = c.String(maxLength: 250),
                        NoiDi = c.String(maxLength: 50),
                        NoiDen = c.String(maxLength: 50),
                        DauDM = c.String(maxLength: 50),
                        ChieuDai = c.String(maxLength: 50),
                        DienDan = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TuyenDuongs");
            DropTable("dbo.TaiXes");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HangHoas");
            DropTable("dbo.DanhSachXes");
            DropTable("dbo.BangKeHoachVanTais");
            DropTable("dbo.BangGiaVanTais");
        }
    }
}
