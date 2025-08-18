using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CstHeadOfficeAndBankInterestD
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double? HeadOffice { get; set; }
        public double? BankInterest { get; set; }
        public string Comments { get; set; }

        public virtual CstHeadOfficeAndBankInterestM YearNavigation { get; set; }
    }
}
