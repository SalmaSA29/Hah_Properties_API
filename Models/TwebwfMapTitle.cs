using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfMapTitle
    {
        public int Id { get; set; }
        public int? OldTitleCode { get; set; }
        public int? NewTitleCode { get; set; }
    }
}
