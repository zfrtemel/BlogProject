using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITagService
    {
        void TagsAdd(Tag tag);
        void TagsEdit(Tag tag);
        void TagsDelete(Tag tag);
        List<Tag> getAllTags();
        Tag getTag(int id);
        List<Tag> getByIdTag(int id);
        List<Tag> getByBlogTags(int id);

    }
}
