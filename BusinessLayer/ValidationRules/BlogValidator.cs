using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage(" Blog Adını Boş Giremezsiniz ");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage(" Blog Adını Adını Min. 5 karakter girmelisiniz ");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage(" Blog  Adını Max. 50 karakter girmelisiniz ");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage(" Blog içeriğini Boş Giremezsiniz ");
            RuleFor(x => x.BlogContent).MinimumLength(20).WithMessage(" Blog içeriğini Min. 20 karakter girmek zorundasınız ");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage(" Blog resmini  Boş Giremezsiniz ");

        }
    }
}
