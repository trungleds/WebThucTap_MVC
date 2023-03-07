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
    public class KhachHangController : Controller
    {

        private CompatyDBContext _context;

        public KhachHangController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {

            //SetViewBag();
            return View();
        }

        public ActionResult GetListKhachHang() // string searchString, int page = 1, int pageSize = 2
        {
            var khachhang = _context.KhachHangs.ToList();
            //var dao = new UserDao();
            //var model = dao.LisAllPaging( searchString, page,pageSize);

            return View(khachhang);
        }



        public ActionResult GetDetailKhachHang(int? id)
        {
            var khachhang = _context.KhachHangs.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(khachhang);
        }
        public async Task<ActionResult> DeleteKhachHang(int id)
        {
            var khachhang = _context.KhachHangs.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new KhachHangDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddKhachHang(KhachHang khachhang)
        {
            if (khachhang.ID != 0) // update
            {
                var dao = new KhachHangDao();
                var result = dao.Update(khachhang);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.KhachHangs.Add(khachhang);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }

    }
}