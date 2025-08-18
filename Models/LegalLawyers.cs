using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class LegalLawyers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Cardno { get; set; }
        public string Email { get; set; }
        public string Tawkel { get; set; }
        public string Notes { get; set; }
        public string Inuser { get; set; }
        public DateTime? Indate { get; set; }
        public string Upuser { get; set; }
        public DateTime? UpDate { get; set; }
    }
}
