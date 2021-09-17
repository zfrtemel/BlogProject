using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        BlogManager bm = new BlogManager(new EfBlogDal());
        public ActionResult CategoryList()
        {
            var categoryValue = cm.getCategoryStatusList();

            return View(categoryValue);
        }
        [HttpPost]
        public JsonResult CategoryAdd(Category category)
        {
            try
            {
                cm.CategoryAdd(category);
                var donen = 1;
                return Json(donen, JsonRequestBehavior.AllowGet);

            }
            catch (Exception hata)
            {
           
                return Json(hata.Message, JsonRequestBehavior.AllowGet);

            }

        }
        [HttpPost]
        public JsonResult CategoryEdit(Category category)
        {
            try
            {
                cm.CategoryEdit(category);
                var donen = 1;
                return Json(donen, JsonRequestBehavior.AllowGet);
            }
            catch (Exception hata)
            {
          
                return Json(hata.Message, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult CategoryDelete(int id)
        {
            try
            {
                var categoryValue = cm.GetCategory(id);
                if (categoryValue.StatusId == 3)
                {
                    RedirectToAction("CategoryList");
                }
                else
                {
                    categoryValue.StatusId = 3;
                    var blogValue = bm.GetAll();
                    foreach (var blog in blogValue)
                    {
                        if (blog.CategoryID == id)
                        {
                            blog.CategoryID = 1;
                            bm.BlogEdit(blog);
                        }
                    }
                }
        
                cm.CategoryDelete(categoryValue);
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (Exception hata)
            {
            
                return Json(hata.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}