
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Vui lòng nhập Username!")
                .MaximumLength(200).WithMessage("Username phải dưới 200 kí tự!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Vui lòng nhập Password!");

        }
    }
}
