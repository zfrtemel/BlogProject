using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
         List<Comment> getBlogComments(int id);
        void CommentAdd(Comment comment);
        void CommentEdit(Comment comment);
        void CommentDelete(Comment comment);
        List<Comment> getCommentList();
        Comment GetComment(int id);
    }
}
