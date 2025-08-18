using Microsoft.AspNetCore.Http;
using PortalAPI.Models.HR;
using System.Threading.Tasks;

namespace PortalAPI.Repository
{
    public interface Main_Interface
    {
        void Main_Log(Main_Log_TicketingAPI LogEntity);
    }
}
