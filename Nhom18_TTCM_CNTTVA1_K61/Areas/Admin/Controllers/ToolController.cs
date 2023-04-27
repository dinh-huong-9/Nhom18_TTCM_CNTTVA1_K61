using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
namespace Nhom18_TTCM_CNTTVA1_K61.Areas.Admin.Controllers
{
    public class ToolController : Controller
    {
        QLtrasenEntities db = new QLtrasenEntities();
        // GET: Admin/Tool
        public ActionResult Index()
        {
            return View(db.Tools.ToList());
        }
        public ActionResult Details(string id)
        {
            var dc = db.Tools.Find(id);
            return View(dc);
        }

        // GET: Admin/Hedieuhanhs/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tool dc)
        {
            try
            {
                //Thêm  sản phẩm mới
                db.Tools.Add(dc);
                // Lưu lại
                db.SaveChanges();
                // Thành công chuyển đến trang index
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // Sửa ttGET lấy ra ID sản phẩm: Admin/New/Edit/5
        public ActionResult Edit(string id)
        {
            // Hiển thị dropdownlist
            var dc = db.Tools.Find(id);
            return View(dc);
        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Tool dc)
        {
            try
            {
                // Sửa sản phẩm theo mã sản phẩm
                var oldItem = db.Tools.Find(dc.IDtools);
                oldItem.IDtools = dc.IDtools;
                oldItem.Imagetools = dc.Imagetools;

                // lưu lại
                db.SaveChanges();
                // xong chuyển qua index
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // Xoá sản phẩm phương thức GET: Admin/Home/Delete/5
        public ActionResult Delete(string id)
        {
            var dc = db.Tools.Find(id);
            return View(dc);
        }

        // Xoá sản phẩm phương thức POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var dc = db.Tools.Find(id);
                // Xoá
                db.Tools.Remove(dc);
                // Lưu lại
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}