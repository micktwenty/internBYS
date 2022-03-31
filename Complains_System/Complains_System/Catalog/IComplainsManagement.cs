using Complains_System.Catalog.Complains.Dtos;
using Complains_System.Catalog.Complains.management;
using Complains_System.Catalog.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog
{
    public interface IComplainsManagement
    {
        public  Task<int> CreateDraft(ComplainsCreateRequest request);
        public Task<int> Delete(int IdComplain);
        public Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request);
        public Task<List<ComplainsViewModel>> GetAll();
        public Task<List<ComplainsViewModel>> GetRequestPost(int ID);

        public Task<ComplainsViewModel> GetbyId(int IDComplain);
        public Task<int> EditCraft(EditDraftRequest request);
        public Task<int> Post(EditDraftRequest request);
        public Task<int> PostRequest(ComplainsCreateRequest request);\
        public Task<int> ReplyComplain(string reply, int idcomplains, int employee);

        public Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request);

        // public Task<PageResult<ComplainsViewModel>> GetRequestComplains(GetComplainsPagingRequest request);
    }
}
