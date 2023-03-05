using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.UI.WebControls;

namespace WebLtic.Models
{
    public class CompatyDBContext : DbContext
    {
        public CompatyDBContext() : base("MyConnecttionString") { }
        public DbSet<BangGiaVanTai> BangGiaVanTais { get; set; }
        public DbSet<BangKeHoachVanTai> BangKeHoachVanTais { get; set; }
        public DbSet<ChuXe> ChuXes { get; set; }
        public DbSet<DanhSachXe> DanhSachXes { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<TaiXe> TaiXes { get; set; }
        public DbSet<TuyenDuong> TuyenDuongs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}