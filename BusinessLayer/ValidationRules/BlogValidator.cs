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
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("Başlık boş olamaz");
            RuleFor(b => b.BlogContent).NotEmpty().WithMessage("Blog içeriği boş olamaz.");
            RuleFor(b => b.BlogImage).NotEmpty().WithMessage("Blog görseli boş olamaz.");
            RuleFor(b => b.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az bir giriş yapın.");
            RuleFor(b => b.BlogTitle).MaximumLength(10).WithMessage("Lütfen 10 karakterden daha fazla bir giriş yapın.");
        }
    }
}
