using PortalAPI.Models;
using PortalAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public interface Employee_Interface
    {
        Task<VM_Resault> GetEmployees();
    }
}
