using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public ActionResult List()
        {
            var commentList = cm.getCommentList();
            return View(commentList);
        }
        public ActionResult DeletedComment(int id)
        {
            var commentValue = cm.GetComment(id);
            commentValue.StatusId = 3;
            cm.CommentDelete(commentValue);
            return RedirectToAction("List");
        }
        public ActionResult CommentStatus(int commentid, int CommentStatusID)
        {
            
            try
            {
                var commentValue = cm.GetComment(commentid);
                commentValue.StatusId = CommentStatusID;
                cm.CommentDelete(commentValue);
                return Json("1", JsonRequestBehavior.AllowGet);

            }
            catch (Exception hata)
            {
                return Json(hata.Message, JsonRequestBehavior.AllowGet);

            }
        }

    }
}