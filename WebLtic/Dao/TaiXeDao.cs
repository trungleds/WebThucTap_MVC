using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class TaiXeDao
    {
        CompatyDBContext db = null;
        public TaiXeDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(TaiXe entity)
        {
            db.TaiXes.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(TaiXe entity)
        {
            try
            {
                var taixe = db.TaiXes.Find(entity.ID);
                taixe.HienThi = entity.HienThi;
                taixe.HoTen = entity.HoTen;
                taixe.BienSoXe = entity.BienSoXe;
                taixe.DienThoai = entity.DienThoai;
                taixe.NamSinh = entity.NamSinh;
                taixe.CCCD = entity.CCCD;
                taixe.NgayCap = entity.NgayCap;
                taixe.NoiCap = entity.NoiCap;
                taixe.DiaChi = entity.DiaChi;
                taixe.LuongCB = entity.LuongCB;
                taixe.GiayTo = entity.GiayTo;
                taixe.DienDan = entity.DienDan;
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
                var taixe = db.TaiXes.Find(id);
                db.TaiXes.Remove(taixe);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(TaiXe taixe)
        {
            throw new NotImplementedException();
        }

        //phân trang
        //public IEnumerable<User> LisAllPaging(int page, int pageSize)
        //{
        //    return db.Users.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        //}
       


    }

}
