using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category Category)
        {
            _categorydal.Insert(Category);
        }

        public void CategoryDelete(Category Category)
        {
            _categorydal.Update(Category);
        }

        public void CategoryEdit(Category Category)
        {
            _categorydal.Update(Category);
        }

        public List<Category> GetAll()
        {
            return _categorydal.List();
        }

        public Category GetCategory(int id)
        {
            return _categorydal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetCategoryById(int id)
        {
            return _categorydal.List(x => x.CategoryID == id);
        }

        public List<Category> getCategoryList()
        {
            throw new NotImplementedException();
        }

        public List<Category> getCategoryStatusList()
        {
            return _categorydal.List(x => x.StatusId != 3);
        }

        public List<Category> getDeletedList()
        {
            return _categorydal.List(x => x.StatusId == 3);
        }
    }
}
