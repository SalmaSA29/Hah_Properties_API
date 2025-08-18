using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Careers
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? MaxSalary { get; set; }
        public int? MinSalary { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
