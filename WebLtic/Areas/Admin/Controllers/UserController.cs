using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLtic.Models;
using WebLtic.Dao;
using PagedList;


namespace WebLtic.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User

        private CompatyDBContext _context;

        public UserController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListUser(string search = "", int page = 1 ,int pageSize = 3)
        {
            //var user = _context.Users.ToList();

            // Search
            List<User> users = _context.Users.Where(row => row.UserName.Contains(search)).ToList();
            ViewBag.Search = search;

            // paging
            var dao = new UserDao();
            var model = dao.LisAllPaging(page, pageSize);


            return View(users);
        }
        public ActionResult GetDetailUser(int? id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(user);
        }
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = _context.Users.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new UserDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddUser(User user)
        {
            if (user.ID != 0) // update
            {
                var dao = new UserDao();
                var result = dao.Update(user);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
    }
}