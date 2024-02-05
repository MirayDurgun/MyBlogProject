using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {

            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Firma adını tarihini boş geçemezsiniz");
            RuleFor(x => x.JobTitle).NotEmpty().WithMessage("İş ünvanını tarihini boş geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("İş açıklamasını tarihini boş geçemezsiniz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("İş başlangıç tarihini boş geçemezsiniz");
        }
    }
}
