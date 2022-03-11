using DUE_Complains.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Dtos
{
    public interface IAccountManagement
    {
        int Create(AccountCreateRequest request);
        int ChangePwd(ChangePwdRequest request);
    }
}
