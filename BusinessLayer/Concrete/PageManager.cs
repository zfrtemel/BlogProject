using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class PageManager:IPageService
    {
        IPageDal _pageDal;

        public PageManager(IPageDal pageDal)
        {
            _pageDal = pageDal;
        }
    }
}
