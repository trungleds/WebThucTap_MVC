using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebLtic.Models;

namespace WebLtic.Dao
{
    public class UserDao
    {
        CompatyDBContext db = null;
        public UserDao()
        {
            db = new CompatyDBContext();
        }

        // Insert
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        // Update
        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Password = entity.Password;
                user.Name = entity.Name;
                user.Addess = entity.Addess;
                user.Email = entity.Email;
                user.Phone = entity.Phone;
                user.ModifedBy = entity.ModifedBy;
                user.ModifedDate = entity.ModifedDate;
                user.Status = entity.Status;
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
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object Delete(User user)
        {
            throw new NotImplementedException();
        }

        //phân trang
        public IEnumerable<User> LisAllPaging( int page, int pageSize)
        {
                return db.Users.OrderByDescending(x=>x.CreateDate).ToPagedList(page, pageSize);
        }
        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }
        public List<User> ListAll()
        {
            return db.Users.Where(x => x.Status == true).ToList();
        }

        internal object Update(ChuXe chuxe)
        {
            throw new NotImplementedException();
        }
    }

}
