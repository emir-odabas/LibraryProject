using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OgrenciValidator :AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(o => o.Ad ).NotEmpty();
            RuleFor(o => o.Soyad).NotEmpty();
            RuleFor(o => o.Puan).GreaterThanOrEqualTo(3);
        }
    }
}
