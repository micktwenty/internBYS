using DUE_Complains.BackendAPI.Commons;
using DUE_Complains.BackendAPI.Complains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.BackenAPI.Complains
{
    public interface IPublicComplains
    {
        Task<PageResult<ComplainsViewModel>> GetAllComplainsByDep(GetComplainsPagingRequest request);

    }
}
