using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogEdit(Blog blog);
        void blogDelete(Blog blog);
        List<Blog> GetAll();
        List<Blog> getBlogStatusList();
        List<Blog> getDeletedList();
        List<Blog> GetBlogById(int id);
        Blog GetBlog(int id);
       
    }
}
