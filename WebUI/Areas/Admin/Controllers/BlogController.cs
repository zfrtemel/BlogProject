using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.App_Classes;
using WebUI.Models;


namespace WebUI.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
      

        // GET: Blog
        BlogManager bm = new BlogManager(new EfBlogDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        BlogValidator blogValidatior = new BlogValidator();
        dbModels bc = new dbModels();//hem blog lisatesini hem kategori listesini almak için oluşturulmuş modelimiz
        Context context =new Context();
        public ActionResult BlogList()
        {
            var blogList = bm.getBlogStatusList();

            return View(blogList);
        }
        [HttpGet]
        public ActionResult BlogAdd()
        {

            //kategori seçimi için yazılan kod
            bc.Categories = cm.getCategoryStatusList();
            return View(bc);
        }
        [HttpPost]
        public JsonResult BlogAdd(Blog b)
        {
            
            b.AuthorID = 1;// sessiondan alınacak
            b.BlogDate = DateTime.Now;
            b.StatusId = 1;
            ValidationResult result = blogValidatior.Validate(b); 
            if (result.IsValid)
            {
               
                bm.BlogAdd(b);
                var intIdt = bm.GetAll();
               var lastBlog= context.Blogs.Max(x=>x.BlogId);//burada ajaxa success dönecek
                return Json(new { success = true, responseID = lastBlog }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }//burada ise error dönecek
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => string.IsNullOrEmpty(e.ErrorMessage) ? e.Exception.Message : e.ErrorMessage)).ToArray();
                return Json(new { success = false, errors = errors },JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult BlogEdit(int id)
        {
            bc.Blogs = bm.GetBlogById(id);
            bc.Blogs.Select(x => x.CategoryID);
            bc.Categories = cm.getCategoryStatusList();
            return View(bc);
        }
        [HttpPost]
        public ActionResult BlogEdit(Blog blog)
        {
            blog.AuthorID = 1;// sessiondan alınacak
            blog.BlogDate = DateTime.Now;
          
            ValidationResult result = blogValidatior.Validate(blog);
            if (result.IsValid)
            {
                int donen = 0;
                bm.BlogEdit(blog);
                donen = 1;
                return Json(donen, JsonRequestBehavior.AllowGet);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => string.IsNullOrEmpty(e.ErrorMessage) ? e.Exception.Message : e.ErrorMessage)).ToArray();
                return Json(new { success = false, errors = errors });
            }
        }
        [HttpPost]
        public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                string filePath = "~/Content/images/" + Guid.NewGuid() + Path.GetExtension(file.FileName);
                file.SaveAs(Path.Combine(Server.MapPath(filePath)));
                //Here you can write code for save this information in your database if you want
             
                return Json(filePath);
            }
            return Json(null);
        }
        public ActionResult BlogDeletedList()
        {
            var blogList = bm.getDeletedList();

            return View(blogList);
        }
        public ActionResult BlogDelete(int id)
        {
           var blogValue= bm.GetBlog(id);
            if (blogValue.StatusId == 3)
            {
                blogValue.StatusId = 1;
            }
            else
            {
                blogValue.StatusId = 3;
            }
            bm.blogDelete(blogValue);

             return RedirectToAction("BlogList");
        }
        public ActionResult BlogStatus(int id)
        {
            var blogValue = bm.GetBlog(id);
            if (blogValue.StatusId==2)
            {
                blogValue.StatusId = 1;
            }
            else
            {
                blogValue.StatusId = 2;
            }
            bm.blogDelete(blogValue);
            return RedirectToAction("BlogList");
        }

    }
}