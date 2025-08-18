using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalAPI.Models.InformationTechnology
{
    public class PH_DescGroup_Values
    {
        public int ID { get; set; }
        public int SubDesc_ID { get; set; }
        public string ValueText { get; set; }   
    }
}
