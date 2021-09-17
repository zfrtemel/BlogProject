using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMemberService
    {
        void MembersAdd(Member member);
        void MembersEdit(Member member);
        void MembersMailSubscribe(Member member,int deger);
        void MemberDelete(Member member);
        List<Member> GetAll();
        List<Member> getMemberStatusList();
        List<Member> getDeletedList();
        List<Member> GetMemberById(int id);
        Member GetMember(int id);
      
    }
}
