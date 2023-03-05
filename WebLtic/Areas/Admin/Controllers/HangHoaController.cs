using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLtic.Models;
using WebLtic.Dao;
using System.Threading.Tasks;

namespace WebLtic.Areas.Admin.Controllers
{
    public class HangHoaController : Controller
    {
        private CompatyDBContext _context;

        public HangHoaController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListHangHoa()
        {
            var hanghoa = _context.HangHoas.ToList();


            return View(hanghoa);
        }
        public ActionResult GetDetailHangHoa(int? id)
        {
            var hanghoa = _context.HangHoas.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(hanghoa);
        }
        public async Task<ActionResult> DeleteHangHoa(int id)
        {
            var hanghoa = _context.HangHoas.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new HangHoaDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddHangHoa(HangHoa hanghoa)
        {
            if (hanghoa.ID != 0) // update
            {
                var dao = new HangHoaDao();
                var result = dao.Update(hanghoa);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.HangHoas.Add(hanghoa);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
    }
}