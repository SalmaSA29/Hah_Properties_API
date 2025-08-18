using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class HrRecJobTitleDelete
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string JobUnit { get; set; }
        public string BusinessUnit { get; set; }
        public int? ProTypId { get; set; }
    }
}
