using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        MembersManager mm = new MembersManager(new EfMemberDal());
        public PartialViewResult MailSubscribeAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MailSubscribeAdd(Member m)
        {
            m.StatusId = 1;
            mm.MembersAdd(m);

            return PartialView();
        }

    }
}