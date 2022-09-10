using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz...");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilmez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Olamaz");
            RuleFor(x => x.WriterPassword)
                .MinimumLength(8).WithMessage("en az 8 karakter")
                .MaximumLength(16).WithMessage("en fazla 16 karakter")
                .Matches("[A-Z]").WithMessage("Şifrenizde en az bir büyük harf olmalıdır.")
                .Matches("[a-z]").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
                .Matches("[0-9]").WithMessage("Şifrede en az bir sayı olmalıdır.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 50 karakterin altında veri girişi yapın");
        }

    }
}
