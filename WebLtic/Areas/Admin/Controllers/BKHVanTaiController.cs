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
    public class BKHVanTaiController : Controller
    {

        private CompatyDBContext _context;

        public BKHVanTaiController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListBKHVanTai()
        {
            var bkhvantai = _context.BangKeHoachVanTais.ToList();

            return View(bkhvantai);
        }
        public ActionResult GetDetailBKHVanTai(int? id)
        {
            var bkhvantai = _context.BangKeHoachVanTais.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(bkhvantai);
        }
        public async Task<ActionResult> DeleteBKHVanTai(int id)
        {
            var bkhvantai = _context.BangKeHoachVanTais.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new BKHVantaiDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddBKHVanTai(BangKeHoachVanTai bkhvantai)
        {
            if (bkhvantai.ID != 0) // update
            {
                var dao = new BKHVantaiDao();
                var result = dao.Update(bkhvantai);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.BangKeHoachVanTais.Add(bkhvantai);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
       
    }
}