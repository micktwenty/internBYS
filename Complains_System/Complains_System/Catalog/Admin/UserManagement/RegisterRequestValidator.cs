using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.UserManagement
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Mật khẩu chưa khớp!")
                .NotEmpty().WithMessage("Vui lòng nhập đầy đủ!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Vui lòng nhập đầy đủ!");
            //RuleFor(x => x.IdDepartment).NotEmpty().WithMessage("Vui lòng nhập đầy đủ!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Vui lòng nhập đầy đủ!");
        }
    }
}
