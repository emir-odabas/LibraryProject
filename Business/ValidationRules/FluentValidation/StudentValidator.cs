using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator :AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(o => o.Ad ).NotEmpty();
            RuleFor(o => o.Soyad).NotEmpty();
            RuleFor(o => o.Puan).GreaterThanOrEqualTo(3);
        }
    }
}
