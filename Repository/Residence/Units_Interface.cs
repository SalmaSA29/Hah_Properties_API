using PortalAPI.Models;
using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostAPI.Repository.Residence
{
    public interface Units_Interface
    {
        public Task<VM_Resault> Create(Units unit, string hrCode);
        public Task<VM_Resault> Delete(List<int> ids);
        public Task<VM_Resault> GetAll();
        public Task<VM_Resault> Update(int id, Units unitUpdate, string hrCode);
        public Task<VM_Resault> GetByBuilding(int buildingId);
        public Task<VM_Resault> GetAllPlans();
    }
}
