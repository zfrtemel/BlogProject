using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class MembersController : Controller
    {
        MembersManager mm = new MembersManager();
        public PartialViewResult MailSubscribeAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MailSubscribeAdd(Member m)
        {
            m.MailSubscribe = true;
            mm.msAdd(m);

            return PartialView();
        }

    }
}