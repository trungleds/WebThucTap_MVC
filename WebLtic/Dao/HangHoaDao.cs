using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class HangHoaDao
    {
        CompatyDBContext db = null;
        public HangHoaDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(HangHoa entity)
        {
            db.HangHoas.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(HangHoa entity)
        {
            try
            {
                var hanghoa = db.HangHoas.Find(entity.ID);
                hanghoa.HienThi = entity.HienThi;
                hanghoa.TenHangHoa = entity.TenHangHoa;
                hanghoa.LoaiHangHoa = entity.LoaiHangHoa;
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
                var hanghoa = db.HangHoas.Find(id);
                db.HangHoas.Remove(hanghoa);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(HangHoa hanghoa)
        {
            throw new NotImplementedException();
        }

       
        internal object Update(ChuXe chuxe)
        {
            throw new NotImplementedException();
        }
    }

}
