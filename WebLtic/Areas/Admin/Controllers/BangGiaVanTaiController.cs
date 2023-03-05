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
    public class BangGiaVanTaiController : Controller
    {
        // GET: Admin/BangGiaVanTai
        private CompatyDBContext _context;

        public BangGiaVanTaiController()
        {
            _context = new CompatyDBContext();
        }
        // GET: Admin/User

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult GetListBGVanTai(string search = "")
        {
            //var user = _context.Users.ToList();

            // Search
            List<BangGiaVanTai> bgvantai = _context.BangGiaVanTais.Where(row => row.TenTuyenDuong.Contains(search)).ToList();
            ViewBag.Search = search;

            // paging
            var dao = new BGVanTaiDao();



            return View(bgvantai);
        }
        public ActionResult GetDetailBGVanTai(int? id)
        {   
            var bgvantai = _context.BangGiaVanTais.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(bgvantai);
        }
        public async Task<ActionResult> DeleteBGVanTai(int id)
        {
            var bgvantai = _context.BangGiaVanTais.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new BGVanTaiDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddBGVanTai(BangGiaVanTai bgvantai)
        {
            if (bgvantai.ID != 0) // update
            {
                var dao = new BGVanTaiDao();
                var result = dao.Update(bgvantai);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.BangGiaVanTais.Add(bgvantai);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
       
    }
}