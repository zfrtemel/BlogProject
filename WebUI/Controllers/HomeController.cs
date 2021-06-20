using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        int pageSize = 5;
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int? page)
        {
            if (page.HasValue)
            {
                int pageIndex = pageSize * page.Value;
                var Blogss = bm.GetAll().OrderByDescending(o => o.BlogDate).Skip(pageIndex).Take(pageSize);
               
                if (Request.IsAjaxRequest())
                { return PartialView(Blogss);}
            }
          
            var Blogs = bm.GetAll().OrderByDescending(o => o.BlogDate).Take(pageSize);
            return PartialView(Blogs);
        }
        public PartialViewResult FeaturedPost() 
        {
            var sliders = bm.GetAll().OrderByDescending(o=> o.BlogDate).Take(5);
            return PartialView(sliders);
        }

        public PartialViewResult SiderBar()
        {
            return PartialView();
        }
        
        public ActionResult BlogDetails()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}