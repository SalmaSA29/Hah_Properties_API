using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class WagMainCategory
    {
        public string MainCategoryId { get; set; }
        public string MainCategoryName { get; set; }
        public string MainCategoryNameArabic { get; set; }
        public bool? IsProductive { get; set; }
    }
}
