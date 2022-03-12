using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.System.User
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }
        public Task<bool> Authenticate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register_stu(RegisterRequest_Stu request)
        {
            throw new NotImplementedException();
        }
    }
}
