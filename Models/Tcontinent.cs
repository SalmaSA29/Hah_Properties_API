using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tcontinent
    {
        public Tcontinent()
        {
            Tcountry = new HashSet<Tcountry>();
        }

        public string ContinentId { get; set; }
        public string ContinentEnName { get; set; }
        public string ContinentArName { get; set; }

        public virtual ICollection<Tcountry> Tcountry { get; set; }
    }
}
