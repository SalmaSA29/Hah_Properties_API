using PortalAPI.Models;
using PortalAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public interface Account_Interface
    {
        List<VM_AccountToken> Login(VM_LoginToken Login);
    }
}
