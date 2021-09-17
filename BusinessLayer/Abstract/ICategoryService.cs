using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryEdit(Category category);
        void CategoryDelete(Category category);
        List<Category> GetAll();
        List<Category> getCategoryStatusList();
        List<Category> getCategoryList();
        List<Category> GetCategoryById(int id);
        Category GetCategory(int id);
    }
}
