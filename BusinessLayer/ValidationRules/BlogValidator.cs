using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            //RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
            //RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("Blog başlığı en az 2 karakter olmalıdır");


            //RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog açıklamasını boş geçemezsiniz");
            //RuleFor(x => x.BlogContent).MaximumLength(1000).WithMessage("Blog açıklaması en fazla 1000 karakter olmalıdır");
            //RuleFor(x => x.BlogContent).MinimumLength(100).WithMessage("Blog açıklaması en az 100 karakter olmalıdır");


            //RuleFor(x => x.Category).NotEmpty().WithMessage("Blog kategorisini boş geçemezsiniz");

        }
    }
}
