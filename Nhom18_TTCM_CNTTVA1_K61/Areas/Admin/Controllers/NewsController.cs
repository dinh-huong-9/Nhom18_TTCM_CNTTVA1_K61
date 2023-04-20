using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
namespace Nhom18_TTCM_CNTTVA1_K61.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News
        QLtrasenEntities db = new QLtrasenEntities();
        public ActionResult Index()
        {
            return View(db.News.ToList());
        }
        // GET: Admin/Hedieuhanhs/Details/5
        public ActionResult Details(string id)
        {          
            var bao = db.News.Find(id);
            return View(bao);
        }

        // GET: Admin/Hedieuhanhs/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(News tintuc)
        {
            try
            {
                //Thêm  sản phẩm mới
                db.News.Add(tintuc);
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
            var tt = db.News.Find(id);
            //var hangselected = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang", dt.Mahang);
            //ViewBag.Mahang = hangselected;
            //var hdhselected = new SelectList(db.Hedieuhanhs, "Mahdh", "Tenhdh", dt.Mahdh);
            //ViewBag.Mahdh = hdhselected;          
            return View(tt);
        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(News bao)
        {
            try
            {
                // Sửa sản phẩm theo mã sản phẩm
                var oldItem = db.News.Find(bao.IDcontent);
                oldItem.Namecontent = bao.Namecontent;
                oldItem.Content = bao.Content;
                oldItem.Imagecontent = bao.Imagecontent;              
                oldItem.Descrition = bao.Descrition;
                oldItem.Content2 = bao.Content2;
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
            var sp = db.News.Find(id);
            return View(sp);
        }

        // Xoá sản phẩm phương thức POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                //Lấy được thông tin sản phẩm theo ID(mã sản phẩm)
                var sp = db.News.Find(id);
                // Xoá
                db.News.Remove(sp);
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