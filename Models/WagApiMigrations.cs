using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagApiMigrations
    {
        public int Id { get; set; }
        public string Migration { get; set; }
        public int Batch { get; set; }
    }
}
