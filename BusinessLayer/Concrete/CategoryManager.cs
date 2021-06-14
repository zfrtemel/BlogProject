using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repoCategory = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repoCategory.List();
        }
    }
}
