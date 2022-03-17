
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
    public class RegisterValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.Isemployee).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Vui lòng nhập Username!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Vui lòng nhập Password!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Vui lòng xác nhận mật khẩu!")
                .Equal<RegisterRequest, string>(x => x.Password).WithMessage("Mật khẩu không khớp!");
            RuleFor(x => x.Email).Matches(@"^([\w\.\-] +)@([\w\-] +)((\.(\w){ 2,3})+)$")
                .WithMessage("Nhập đúng địa chỉ Email!").WithName("Địa chỉ Email");
        }
    }
}
