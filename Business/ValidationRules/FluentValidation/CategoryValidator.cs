using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty();
            RuleFor(c => c.CategoryName).Must(StartWithC).WithMessage("Kategory isimleri C harfi ile baslamalidir.");
        }

        private bool StartWithC(string arg)
        {
            return arg.StartsWith("C");
        }
    }
}
