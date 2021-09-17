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
    public class BlogManager : IBlogService
        
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
             _blogDal.Insert(blog);
        }

        public void blogDelete(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public void BlogEdit(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.List();
        }

        public Blog GetBlog(int id)
        {
            return _blogDal.Get(u => u.BlogId==id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.List(x=> x.BlogId==id);
        }



        public List<Blog> getBlogStatusList()
        {
            return _blogDal.List(x => x.StatusId !=3);
        }

        public List<Blog> getDeletedList()
        {
            return _blogDal.List(x => x.StatusId == 3);
        }
    }
}
