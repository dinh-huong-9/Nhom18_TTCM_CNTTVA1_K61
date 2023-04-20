using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
namespace Nhom18_TTCM_CNTTVA1_K61.Controllers
{
    public class HomeController : Controller
    {
        QLtrasenEntities db = new QLtrasenEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            List<News> bao = db.News.ToList();
            return PartialView(bao);
           
        }

        public ActionResult Contact()
        {
       
            return View();
        }
        public ActionResult Introduce()
        {
        
            return View();
        }
        public ActionResult Product()
        {
            List<Product> sp = db.Products.ToList();
            return PartialView(sp);
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
        public ActionResult DetailNews(string IDcontent)
        {
            var dcontent = db.News.SingleOrDefault(n => n.IDcontent == IDcontent);
            if (dcontent == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(dcontent);
        }
    }
}