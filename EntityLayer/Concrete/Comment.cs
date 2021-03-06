using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(300)]
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int? ReplyCommentID { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public int? MemberID { get; set; }
        public virtual Member Member { get; set; }
        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }

    }
}
