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
    public class TaiXeController : Controller
    {

        private CompatyDBContext _context;

        public TaiXeController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListTaiXe()
        {
            var taixe = _context.TaiXes.ToList();
            return View(taixe);
        }
        public ActionResult GetDetailTaiXe(int? id)
        {
            var taixe = _context.TaiXes.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(taixe);
        }
        public async Task<ActionResult> DeleteTaiXe(int id)
        {
            var taixe = _context.TaiXes.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new TaiXeDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddTaiXe(TaiXe taixe)
        {
            if (taixe.ID != 0) // update
            {
                var dao = new TaiXeDao();
                var result = dao.Update(taixe);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.TaiXes.Add(taixe);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
    }
}