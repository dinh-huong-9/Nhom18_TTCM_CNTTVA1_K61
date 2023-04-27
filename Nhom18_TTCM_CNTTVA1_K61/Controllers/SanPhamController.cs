using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
using PagedList;
namespace Nhom18_TTCM_CNTTVA1_K61.Controllers
{
    public class SanPhamController : Controller
    {
        QLtrasenEntities db = new QLtrasenEntities();
        // GET: SanPham
        public ActionResult Product(int? page)
        {
            if (page == null) page = 1;
            int pageSize = 6;
            int pageNumber = (page ?? 1);
          
            List<Product> sp = db.Products.ToList();           
            return PartialView(sp.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Detail(string Idproduct)
        {
            var chitiet = db.Products.SingleOrDefault(n => n.Idproduct == Idproduct);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }
        public PartialViewResult Category()
        {
            return PartialView(db.Categories.ToList());
        }
        public ViewResult ProductByCategory(string IDcategory = "1")
        {
            List<Product> lstProducts = db.Products.Where(n => n.IDcategory == IDcategory).OrderBy(n => n.IDcategory).ToList();
            if (lstProducts.Count == 0)
            {
                ViewBag.Products = "Khong co san pham nay";
                ViewBag.lstProducts = db.Products.ToList();
            }
            ViewBag.IDcategory = IDcategory;
            return View(lstProducts);
        }
        //thuong hieu
        public PartialViewResult Trademark()
        {
            return PartialView(db.Trademarks.ToList());
        }
        public ViewResult ProductByTrademark(string IDtrademark = "1")
        {
            List<Product> lstProducts = db.Products.Where(n => n.IDtrademark == IDtrademark).OrderBy(n => n.IDtrademark).ToList();
            if (lstProducts.Count == 0)
            {
                ViewBag.Products = "Khong co san pham nay";
                ViewBag.lstProducts = db.Products.ToList();
            }
            ViewBag.IDtrademark = IDtrademark;
            return View(lstProducts);
        }
        //sx theo thu tu mac dinh
        public PartialViewResult TTMD()
        {
            return PartialView(db.Products.ToList());
        }

        public ViewResult SpTTMD()
        {
            List<Product> sp = db.Products.ToList();
            return View(sp);
        }
        //sx tang dan
        public PartialViewResult sxtheogiact()
        {
            return PartialView(db.Products.ToList());
        }
        public ViewResult sptheogiact(string Idproduct= "1")
        {
            List<Product> sp = db.Products.OrderBy(n => n.Price).ToList();
            if (sp.Count == 0)
            {
                ViewBag.Products = "Khong co san pham nay";
                ViewBag.lstProducts = db.Products.ToList();
            }
            ViewBag.Idproduct = Idproduct;
            return View(sp);
        }
        //sp theo thap-cao 
        public PartialViewResult sxtheogiatc()
        {
            return PartialView(db.Products.ToList());
        }
        public ViewResult sptheogiatc(string Idproduct = "1")
        {
            List<Product> sp = db.Products.OrderByDescending(n => n.Price).ToList();
            if (sp.Count == 0)
            {
                ViewBag.Products = "Khong co san pham nay";
                ViewBag.lstProducts = db.Products.ToList();
            }
            ViewBag.Idproduct = Idproduct;
            return View(sp);
        }

    }
}