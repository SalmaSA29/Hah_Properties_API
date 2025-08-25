using PortalAPI.ViewModel;
using System.Threading.Tasks;

namespace PortalAPI.Repository.AIS
{
    public interface Employees_Lookup_Interface
    {
        public Task<VM_Resault> GetAll();
    }
}
