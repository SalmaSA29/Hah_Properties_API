using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstHeadOfficeAndBankInterestM
    {
        public CstHeadOfficeAndBankInterestM()
        {
            CstHeadOfficeAndBankInterestD = new HashSet<CstHeadOfficeAndBankInterestD>();
        }

        public int Year { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<CstHeadOfficeAndBankInterestD> CstHeadOfficeAndBankInterestD { get; set; }
    }
}
