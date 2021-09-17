using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class dbModels
    {
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
        public Category Category{ get; set; }
        public Blog Blog { get; set; }
    }
}