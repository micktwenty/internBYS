using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.System.User
{
     public interface IUserService
    {
        Task<bool> Authenticate(LoginRequest request);
        Task<bool> Register_stu(RegisterRequest_Stu request);
    }
}
