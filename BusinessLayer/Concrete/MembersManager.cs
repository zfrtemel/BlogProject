using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MembersManager : IMemberService
    {
        IMemberDal _memberDal;

     
        public MembersManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetAll()
        {
            return _memberDal.List();
        }

        public List<Member> getDeletedList()
        {
            return _memberDal.List(x=>x.StatusId==3);
        }

        public Member GetMember(int id)
        {
            return _memberDal.Get(x => x.MemberID == id);

        }

        public List<Member> GetMemberById(int id)
        {
            return _memberDal.List(x => x.MemberID == id);
        }

        public List<Member> getMemberStatusList()
        {
            return _memberDal.List(x => x.StatusId == 1);
        }

        public void MemberDelete(Member member)
        {
             _memberDal.Update(member);
        }

        public void MembersAdd(Member member)
        {
            _memberDal.Insert(member);
        }

        public void MembersEdit(Member member)
        {
            _memberDal.Update(member);
        }

        public void MembersMailSubscribe(Member member,int deger)
        {
            if (deger==1)
            {
                _memberDal.Update(member);
            }
            else
            {
                _memberDal.Insert(member);
            }
        }
    }
}
