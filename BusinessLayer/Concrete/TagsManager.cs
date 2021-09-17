using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TagsManager : ITagService
    {
        ITagDal _tagDal;
        public TagsManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public List<Tag> getAllTags()
        {
            return _tagDal.List();
        }

        public List<Tag> getByBlogTags(int id)
        {
            return _tagDal.List(x=>x.BlogId==id);
        }

        public List<Tag> getByIdTag(int id)
        {
            return _tagDal.List(x => x.TagID == id);
        }

        public Tag getTag(int id)
        {
            return _tagDal.Get(x => x.TagID == id);
        }

        public void TagsAdd(Tag tag)
        {
            _tagDal.Insert(tag);
        }

        public void TagsDelete(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public void TagsEdit(Tag tag)
        {
            _tagDal.Update(tag);
        }
    }
}
