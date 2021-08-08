using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        GenericRepository<Blog> repoBlog = new GenericRepository<Blog>();
        public List<Blog> GetAll()
        {
            return repoBlog.List();
        }
        public List<Blog> GetBlogDetailsList(int id)
        {
            return repoBlog.List(x => x.BlogId == id);
        }
    }
}
