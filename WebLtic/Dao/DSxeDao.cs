using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class DSxeDao
    {
        CompatyDBContext db = null;
        public DSxeDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(DanhSachXe entity)
        {
            db.DanhSachXes.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(DanhSachXe entity)
        {
            try
            {
                var dsxe = db.DanhSachXes.Find(entity.ID);
                dsxe.TenXe = entity.TenXe;
                dsxe.BienSoXe = entity.BienSoXe;
                dsxe.LoaiXe = entity.LoaiXe;
                dsxe.ChuXe = entity.ChuXe;
                dsxe.TaiXe = entity.TaiXe;
                dsxe.MauSon = entity.MauSon;
                dsxe.HangXe = entity.HangXe;
                dsxe.NgayTao = entity.NgayTao;
                dsxe.GhiChu = entity.GhiChu;
                dsxe.HienThi = entity.HienThi;
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
                var dsxe = db.DanhSachXes.Find(id);
                db.DanhSachXes.Remove(dsxe);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(DanhSachXe dsxe)
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
        public List<User> ListAll()
        {
            return db.Users.Where(x => x.Status == true).ToList();
        }



    }
}
