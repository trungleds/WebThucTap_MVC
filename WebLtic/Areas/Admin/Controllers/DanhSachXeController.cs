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
    public class DanhSachXeController : Controller
    {

        private CompatyDBContext _context;

        public DanhSachXeController()
        {
            _context = new CompatyDBContext();
        }

        public ActionResult Index()
        {

            //SetViewBag();
            return View();
        }

        public ActionResult GetListDSXe(/*,int page = 1, int pageSize = 4*/) // string searchString, int page = 1, int pageSize = 2
        {
            var dsxe = _context.DanhSachXes.ToList();
            
            //var dao = new UserDao();
            //var model = dao.LisAllPaging( searchString, page,pageSize);

            return View(dsxe);
        }



        public ActionResult GetDetailDSXe(int? id)
        {
            var dsxe = _context.DanhSachXes.Where(x => x.ID == id).FirstOrDefault();
            //var userList = _context.Users.ToList();
            //ViewBag.UserList = new SelectList(userList, "ID", "Name");

            ViewBag.FlagUpdate = false; // insert => false
            if (id != null)
            {
                ViewBag.FlagUpdate = true;
            }

            return View(dsxe);
        }
        public async Task<ActionResult> DeleteDSXe(int id)
        {
            var dsxe = _context.DanhSachXes.Where(x => x.ID == id).FirstOrDefault();
            if (id != 0)
            {
                await new DSxeDao().DeleteAsync(id);
            }
            var m_Result = new { ID = 0, Text = "Delete OK" };
            return Json(m_Result, JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddDSXe(DanhSachXe dsxe)
        {
            if (dsxe.ID != 0) // update
            {
                var dao = new DSxeDao();
                var result = dao.Update(dsxe);
                var m_Result = new { ID = 0, Text = "Update OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);

            }
            else // insert
            {
                _context.DanhSachXes.Add(dsxe);
                await _context.SaveChangesAsync();
                // return RedirectToAction("Index");
                var m_Result = new { ID = 0, Text = "Add OK" };
                return Json(m_Result, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult DropDownlistXe()
        {
            var dmx = _context.DanhSachXes;
            List<DanhSachXe> lstdx = dmx.ToList();
            SelectList lstdsx = new SelectList(lstdx, "ID", "TenXe");
            ViewBag.dsxe = lstdsx;
            return View();
        }
    }
}