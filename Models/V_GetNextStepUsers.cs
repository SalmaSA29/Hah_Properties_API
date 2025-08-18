using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortalAPI.Models
{
    public partial class V_GetNextStepUsers
    {
        [Key]
        public string User_HR_Code { get; set; }
        public string name { get; set; }
        public string Title_ID { get; set; }
    }
}
