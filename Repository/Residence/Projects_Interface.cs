using PortalAPI.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortalAPI.Models;

namespace PostAPI.Repository.Residence
{
    public interface Projects_Interface
    {
        public Task<VM_Resault> Create(Projects project, string hrCode);
        public Task<VM_Resault> GetAll();
        public Task<VM_Resault> Delete(List<int> ids);
        public Task<VM_Resault> Update(int id, Projects project, string hrCode);
    }
}
