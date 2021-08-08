﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Tag
    {
        [Key]
        public int TagID { get; set; }
        [StringLength(30)]
        public String TagName{ get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog{ get; set; }
    }
}
