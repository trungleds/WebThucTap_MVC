using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class TuyenDuongDao
    {
        CompatyDBContext db = null;
        public TuyenDuongDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(TuyenDuong entity)
        {
            db.TuyenDuongs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(TuyenDuong entity)
        {
            try
            {
                var tuyenduong = db.TuyenDuongs.Find(entity.ID);
                tuyenduong.MaTuyen = entity.MaTuyen;
                tuyenduong.TenTuyenDuong = entity.TenTuyenDuong;
                tuyenduong.NoiDi = entity.NoiDi;
                tuyenduong.NoiDen = entity.NoiDen;
                tuyenduong.DauDM = entity.DauDM;
                tuyenduong.ChieuDai = entity.ChieuDai;
                tuyenduong.DienDan = entity.DienDan;
               
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
                var tuyenduong = db.TuyenDuongs.Find(id);
                db.TuyenDuongs.Remove(tuyenduong);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(TuyenDuong tuyenduong)
        {
            throw new NotImplementedException();
        }

        //   phân trang
        //public IEnumerable<TuyenDuong> LisAllPaging(string searchString, int page, int pageSize)
        //{
        //    IQueryable<TuyenDuong> model = db.TuyenDuongs;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        model = model.Where(x => x.TenTuyenDuong.Contains(searchString));
        //    }
        //    return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
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
