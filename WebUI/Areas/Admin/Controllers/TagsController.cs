using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class TagsController : Controller
    {
        TagsManager tm = new TagsManager(new EfTagDal());
        public ActionResult List()
        {
           var tagsValue= tm.getAllTags();
            return View(tagsValue);
        }
        public ActionResult TagsAdd(Tag tag)
        {
            try
            {
                tm.TagsAdd(tag);
                return Json(new { success = true, responseText = "okey" }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception hata)
            {

                return Json(new { success = false, responseText =hata.Message }, JsonRequestBehavior.AllowGet);
            }
            
        }
        public ActionResult DeletedTags(int id)
        {
            try
            {
                var tagsValue = tm.getTag(id);
                tm.TagsDelete(tagsValue);
                return RedirectToAction("List");

            }
            catch (Exception hata)
            {

                return Json(hata, JsonRequestBehavior.AllowGet);
            }
        }
    }
}