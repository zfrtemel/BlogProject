using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager();
        // GET: Comment
        public PartialViewResult BlogCommentList(int id)
        {
            var comments = cm.getBlogComments(id);
            return PartialView(comments);
        }
    }
}