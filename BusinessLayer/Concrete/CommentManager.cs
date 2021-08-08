using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CommentManager
    {
        GenericRepository<Comment> repoComments = new GenericRepository<Comment>();
    
        public List<Comment> getBlogComments(int id)
        {
            return repoComments.List(x => x.BlogId == id);
        }
    }
}
