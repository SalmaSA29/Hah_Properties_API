using PortalAPI.ViewModel;
using System.Threading.Tasks;

namespace PortalAPI.Repository.AIS
{
    public interface Employees_Interface
    {
        public Task<VM_Resault> GetAll();
    }
}
