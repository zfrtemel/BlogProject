using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(30)]
        public String CategoryName { get; set; }
        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
