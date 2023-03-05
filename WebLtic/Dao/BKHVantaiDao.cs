using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class BKHVantaiDao
    {
        CompatyDBContext db = null;
        public BKHVantaiDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(BangKeHoachVanTai entity)
        {
            db.BangKeHoachVanTais.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(BangKeHoachVanTai entity)
        {
            try
            {
                var bkhvantai = db.BangKeHoachVanTais.Find(entity.ID);
                bkhvantai.NgayLapKH = entity.NgayLapKH;
                bkhvantai.KhachHang = entity.KhachHang;
                bkhvantai.NgayNhan = entity.NgayNhan;
                bkhvantai.NoiNhanHang = entity.NoiNhanHang;
                bkhvantai.NgayGiaoHang = entity.NgayGiaoHang;
                bkhvantai.NoiGiaoHang = entity.NoiGiaoHang;
                bkhvantai.TenHang = entity.TenHang;
                bkhvantai.DVT = entity.DVT;
                bkhvantai.SoLuong = entity.SoLuong;
                bkhvantai.DonGia = entity.DonGia;
                bkhvantai.ThanhTien = entity.ThanhTien;
                bkhvantai.TienDaGiao = entity.TienDaGiao;
                bkhvantai.TienThieu = entity.TienThieu;
                bkhvantai.DienDan = entity.DienDan;
                bkhvantai.TinhTrang = entity.TinhTrang;
                bkhvantai.ThanhToan = entity.ThanhToan;
                bkhvantai.TongBX = entity.TongBX;
                bkhvantai.PhiPhatSinh = entity.PhiPhatSinh;
                bkhvantai.BienSoXe = entity.BienSoXe;
                bkhvantai.ChuHang = entity.ChuHang;
                bkhvantai.NgayTao = entity.NgayTao;
                bkhvantai.NguoiTao = entity.NguoiTao;
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        // Delete
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var bkhvantai = db.BangKeHoachVanTais.Find(id);
                db.BangKeHoachVanTais.Remove(bkhvantai);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(BangKeHoachVanTai bkhvantai)
        {
            throw new NotImplementedException();
        }

    }
}
