using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Page
    {
        [Key]
        public int PagesID { get; set; }
        [StringLength(50)]
        public string PageName { get; set; }
        public string PageContent { get; set; }
        public DateTime PageAddedDate { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

    }
}
