﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Member
    {
        [Key]
        public int MemberID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(250)]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool MailSubscribe { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}