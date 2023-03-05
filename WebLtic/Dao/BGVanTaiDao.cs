using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class BGVanTaiDao
    {
        CompatyDBContext db = null;
        public BGVanTaiDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(BangGiaVanTai entity)
        {
            db.BangGiaVanTais.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(BangGiaVanTai entity)
        {
            try
            {
                var bgvantai = db.BangGiaVanTais.Find(entity.ID);
                bgvantai.TenTuyenDuong   = entity.TenTuyenDuong;
                bgvantai.TenHangHoa = entity.TenHangHoa;
                bgvantai.DVT = entity.DVT;
                bgvantai.DonGia = entity.DonGia;
                bgvantai.DienDan = entity.DienDan;
                bgvantai.ChiNhanh = entity.ChiNhanh;
                bgvantai.NgayTao = entity.NgayTao;
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
                var bgvantai = db.BangGiaVanTais.Find(id);
                db.BangGiaVanTais.Remove(bgvantai);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(BangGiaVanTai bgvantai)
        {
            throw new NotImplementedException();
        }

    }
}
