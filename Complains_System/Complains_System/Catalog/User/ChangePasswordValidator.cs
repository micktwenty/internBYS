using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordValidator()
        {
            RuleFor(x => x.OldPass).NotEmpty().WithMessage("Vui lòng nhập mật khẩu cũ!"); ;
            RuleFor(x => x.NewPass).NotEmpty().WithMessage("Vui lòng nhập mật khẩu mới!");
            RuleFor(x => x.ConfirmNewPass).NotEmpty().WithMessage("Vui lòng xác nhận mật khẩu!")
                .Equal<ChangePasswordRequest, string>(x => x.NewPass).WithMessage("Mật khẩu không khớp!");
           
        }
    }
}
