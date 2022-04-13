using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Complains.management
{
    public class ComplainsRequestValidator : AbstractValidator<ComplainsCreateRequest>
    {
        public ComplainsRequestValidator()
        {
            RuleFor(x => x.Title).MaximumLength(70).WithMessage("Độ dài tối đa của tiêu đề là 70 kí tự!");
        }
    }
}
