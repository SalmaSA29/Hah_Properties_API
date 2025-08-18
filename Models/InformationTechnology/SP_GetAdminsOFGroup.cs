using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models.InformationTechnology
{
    public class SP_GetAdminsOFGroup
    {
        [Key]
        public int ID { get; set; }
        public string HRCode { get; set; }
        public int? Group_ID { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
