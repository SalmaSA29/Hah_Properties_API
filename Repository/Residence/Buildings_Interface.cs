using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortalAPI.Repository.Residence
{
    public interface Buildings_Interface
    {
        public Task<VM_Resault> Create(Buildings building, string hrCode);
        public Task<VM_Resault> Delete(List<int> ids);
        public Task<VM_Resault> GetAll();
        public Task<VM_Resault> Update(int id, Buildings buildingUpdate, string hrCode);
        public Task<VM_Resault> GetByProject(int projectId);

    }
}
