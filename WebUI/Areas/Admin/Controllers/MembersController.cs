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
    public class MembersController : Controller
    {
        MembersManager mb = new MembersManager(new EfMemberDal());
        // GET: Admin/Members
        public ActionResult List()
        {
           var MemberValue= mb.GetAll();
            return View(MemberValue);
        }

        public ActionResult Edit(int id)
        {
            var memberValue = mb.GetMemberById(id);
            return View(memberValue);
        }


        [HttpPost]
        public JsonResult Edit(Member member)
        {

            try
            {
                mb.MembersEdit(member);
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (Exception hata)
            {
                return Json(hata.Message, JsonRequestBehavior.AllowGet);


            }

        }

        public JsonResult MembersStatus(int id)
        {
            try
            {
                var memberValue = mb.GetMember(id);
                if (memberValue.StatusId==1)
                {
                    memberValue.StatusId = 2;
                }
                else
                {
                    memberValue.StatusId = 1;
                }
                mb.MemberDelete(memberValue);
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (Exception hata)
            {
                return Json(hata.Message, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var memberValue = mb.GetMember(id);
                memberValue.StatusId = 3;
                mb.MemberDelete(memberValue);
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (Exception hata)
            {
                return Json(hata.Message, JsonRequestBehavior.AllowGet);
            }
         
        }
    }
}
