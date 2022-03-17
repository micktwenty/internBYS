
using Complains_System.Catalog.Complains.Dtos;
using Complains_System.Catalog.Complains.management;
using Complains_System.Catalog.Public;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Complains
{
    public interface IPublicComplains
    {
        Task<PageResult<ComplainsViewModel>> GetAllComplainsByDep(GetComplainsPagingRequest request);

    }
}
