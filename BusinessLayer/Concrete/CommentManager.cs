using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class CommentManager:ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public void CommentEdit(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> getBlogComments(int id)
        {
            return _commentDal.List(x => x.BlogId == id);
        }

        public Comment GetComment(int id)
        {
            return _commentDal.Get(x=>x.CommentID==id);
        }

        public List<Comment> getCommentList()
        {
            return _commentDal.List(x=>x.StatusId!=3);
        }
    }
}
