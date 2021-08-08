using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class MembersManager
    {
        GenericRepository<Member> repoMember = new GenericRepository<Member>();
        public int msAdd(Member m)
        {
            if (m.Email.Length<=10 || m.Email.Length>=50)
            {
                return -1;
            }
            return repoMember.Insert(m);
        }
        public int mmAdd(Member m)
        {
            if (m.Name.Length >50 || m.Email.Length > 50 || m.UserName.Length > 20 ||
                m.Password.Length > 250|| m.Name == "" || m.Email == "" ||
                m.UserName == "" || m.Password == "" ||m.Password.Length<=7)
            {
                return -1;
            }
            return repoMember.Insert(m);

        }
        public int mmLogin(Member m)
        {
            if (m.UserName==""||m.UserName=="")
            {
                
            }
            return -1;
        }
        


    }
}
