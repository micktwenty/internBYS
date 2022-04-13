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
        public  Task<string> CreateDraft(ComplainsCreateRequest request); //tạo nháp
        public Task<int> Delete(int IdComplain); // xoá
        public Task<PageResult<ComplainsViewModel>> GetAllbyKeyword(GetComplainsPagingRequest request); //getlist
        public Task<List<ComplainsViewModel>> GetAll();// get all
        public Task<List<ComplainsViewModel>> GetRequestPost(int ID);//get danh sách chờ duyệt qua id department
        public Task<ComplainsViewModel> GetbyId(int IDComplain);// tìm kiếm dựa trên id complains
        public Task<string> EditCraft(EditDraftRequest request); //sửa nháp
        public Task<int> DenyPost(string reply, int idcomplains, int employee); //Từ chối giải quyết
        public Task<int> SpamPost(string reply, int idcomplains, int employee); //Từ chối giải quyết

        public Task<string> PostRequest(ComplainsCreateRequest request);// đăng bài
        public Task<int> ReplyComplain(string reply, int idcomplains, int employee);// trả lời complains

        public Task<PageResult<ComplainsViewModel>> GetOwnPaging(GetComplainsPagingRequest request);// lấy ra danh sách complains của mình

        //public Task<List<ComplainsViewModel>> GetRequestComplains(GetComplainsPagingRequest request);//get danh sách chờ duyệt
    }
}
