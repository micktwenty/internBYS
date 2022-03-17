using DUE_Complains.BackendAPI.Commons;
using DUE_Complains.BackendAPI.Complains;
using DUE_Complains.BackendAPI.Complains.management;

using DUE_Complains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.BackendAPI
{
    public interface IComplainsManagement
    {
        public  Task<int> CreateDraft(ComplainsCreateRequest request);
        public Task<int> Delete(int IdComplain);
        public Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request);
        public Task<List<ComplainsViewModel>> GetAll();
        public Task<ComplainsViewModel> GetbyId(int IDComplain);
        public Task<int> EditCraft(EditDraftRequest request);
        public Task<int> PostRequest(EditDraftRequest request);
        public Task<int> ReplyComplain(string reply, int idcomplains, int employee);

        public Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request);

        // public Task<PageResult<ComplainsViewModel>> GetRequestComplains(GetComplainsPagingRequest request);
    }
}
