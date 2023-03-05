using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class ChuXeDao
    {
        CompatyDBContext db = null;
        public ChuXeDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(ChuXe entity)
        {
            db.ChuXes.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(ChuXe entity)
        {
            try
            {
                var chuxe = db.ChuXes.Find(entity.ID);
                chuxe.HoTen = entity.HoTen;
                chuxe.DienThoai = entity.DienThoai;
                chuxe.CCCD = entity.CCCD;
                chuxe.DiaChi = entity.DiaChi;
                chuxe.DienDan = entity.DienDan;
                chuxe.Title = entity.Title;
                
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
                var chuxe = db.ChuXes.Find(id);
                db.ChuXes.Remove(chuxe);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(ChuXe chuxe)
        {
            throw new NotImplementedException();
        }

        //phân trang
        //public IEnumerable<User> LisAllPaging(int page, int pageSize)
        //{
        //    return db.Users.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        //}
        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }
        public List<User> ListAll()
        {
            return db.Users.Where(x => x.Status == true).ToList();
        }


    }

}
