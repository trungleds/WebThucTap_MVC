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
    public class TuyenDuongController : Controller
    {

        private CompatyDBContext _context;

        public TuyenDuongController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListTuyenDuong()
        {
            var tuyenduong = _context.TuyenDuongs.ToList();

            return View(tuyenduong);
        }
        public ActionResult GetDetailTuyenDuong(int? id)
        {
            var tuyenduong = _context.TuyenDuongs.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(tuyenduong);
        }
        public async Task<ActionResult> DeleteTuyenDuong(int id)
        {
            var tuyenduong = _context.TuyenDuongs.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new TuyenDuongDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddTuyenDuong(TuyenDuong tuyenduong)
        {
            if (tuyenduong.ID != 0) // update
            {
                var dao = new TuyenDuongDao();
                var result = dao.Update(tuyenduong);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.TuyenDuongs.Add(tuyenduong);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
    }
}