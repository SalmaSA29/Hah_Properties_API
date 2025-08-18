using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class Tcountry
    {
        public string CountryId { get; set; }
        public string CountryIsocode { get; set; }
        public string CountryEnName { get; set; }
        public string CountryArName { get; set; }
        public string ContinentId { get; set; }

        public virtual Tcontinent Continent { get; set; }
    }
}
