using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
namespace Nhom18_TTCM_CNTTVA1_K61.Areas.Admin.Controllers
{
    public class TrademarkController : Controller
    {
        QLtrasenEntities db = new QLtrasenEntities();
        // GET: Admin/Trademark
        public ActionResult Index()
        {
            return View(db.Trademarks.ToList());
        }
        public ActionResult Details(string id)
        {
            var th = db.Trademarks.Find(id);
            return View(th);
        }

        // GET: Admin/Hedieuhanhs/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Trademark th)
        {
            try
            {
                //Thêm  sản phẩm mới
                db.Trademarks.Add(th);
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
            var th = db.Trademarks.Find(id);
            return View(th);
        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Trademark th)
        {
            try
            {
                // Sửa sản phẩm theo mã sản phẩm
                var oldItem = db.Trademarks.Find(th.IDtrademark);
                oldItem.IDtrademark = th.IDtrademark;
                oldItem.Name = th.Name;

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
            var th = db.Trademarks.Find(id);
            return View(th);
        }

        // Xoá sản phẩm phương thức POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var th = db.Trademarks.Find(id);
                // Xoá
                db.Trademarks.Remove(th);
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