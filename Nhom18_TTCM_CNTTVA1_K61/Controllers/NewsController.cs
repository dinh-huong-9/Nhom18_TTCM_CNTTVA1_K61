using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom18_TTCM_CNTTVA1_K61.Models;
namespace Nhom18_TTCM_CNTTVA1_K61.Controllers
{
    public class NewsController : Controller
    {
        QLtrasenEntities db = new QLtrasenEntities();
        // GET: News
        public ActionResult New()
        {
            List<News> bao = db.News.ToList();
            return PartialView(bao);
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
        public ActionResult BVM(string IDcontent)
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