using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_Requester
    {
    
        public long ID { get; set; }
        public string User_HR_Code { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }

    }
}
