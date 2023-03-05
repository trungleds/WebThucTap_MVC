using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLtic.Dao;
using WebLtic.Models;

namespace WebLtic.Areas.Admin.Controllers
{
    public class ChuXeController : Controller
    {
        // GET: Admin/ChuXe

        private CompatyDBContext _context;

        public ChuXeController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListChuXe(string search = "")
        {
            //var user = _context.Users.ToList();

            // Search
            List<ChuXe> chuxes = _context.ChuXes.Where(row => row.HoTen.Contains(search)).ToList();
            ViewBag.Search = search;

            // paging
            var dao = new ChuXeDao();
            


            return View(chuxes);
        }
        public ActionResult GetDetailChuXe(int? id)
        {
            var chuxe = _context.ChuXes.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(chuxe);
        }
        public async Task<ActionResult> DeleteChuXe(int id)
        {
            var chuXe = _context.ChuXes.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new ChuXeDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddChuXe(ChuXe chuxe)
        {
            if (chuxe.ID != 0) // update
            {
                var dao = new ChuXeDao();
                var result = dao.Update(chuxe);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.ChuXes.Add(chuxe);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult bangChuXe( )
        {
            var chuXe = _context.ChuXes.ToList();
            
            return View(chuXe);
        }
    }
}