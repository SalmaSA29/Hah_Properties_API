using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalAPI.Repository.Residence
{
    public interface Requests_Interface
    {
        public Task<VM_Resault> Create(Requests request, string hrCode);
        public Task<VM_Resault> Delete(List<int> ids);
        public Task<VM_Resault> PatchStatus(int id, int status, string hrCode);
        public Task<VM_Resault> GetAll();
        public Task<VM_Resault> GetByUser(string hrCode);
    }
}
