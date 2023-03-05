using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class KhachHangDao
    {
        CompatyDBContext db = null;
        public KhachHangDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(KhachHang entity)
        {
            db.KhachHangs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(KhachHang entity)
        {
            try
            {
                var khachang = db.KhachHangs.Find(entity.ID);
                khachang.DoiTac = entity.DoiTac;
                khachang.DiaChi = entity.DiaChi;
                khachang.DienThoai = entity.DienThoai;
                khachang.NoBanDau = entity.NoBanDau;
                khachang.KhuVuc = entity.KhuVuc;
                khachang.LoaiDoiTac = entity.LoaiDoiTac;
                khachang.CCCD = entity.CCCD;
                khachang.Fax = entity.Fax;
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
                var khachhang = db.KhachHangs.Find(id);
                db.KhachHangs.Remove(khachhang);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(KhachHang khachhang)
        {
            throw new NotImplementedException();
        }

        //   phân trang
        //public IEnumerable<User> LisAllPaging(string searchString, int page, int pageSize)
        //{
        //    IQueryable<User> model = db.Users;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        model = model.Where(x => x.UserName.Contains(searchString) || x.Name.Contains(searchString));
        //    }
        //    return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        //}




    }
}
