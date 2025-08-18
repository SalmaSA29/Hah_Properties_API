using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CForm
    {
        public CForm()
        {
            CFormPermision = new HashSet<CFormPermision>();
            PrintDocGroupFilters = new HashSet<PrintDocGroupFilters>();
            PrintDocGroupGroups = new HashSet<PrintDocGroupGroups>();
        }

        public string FormId { get; set; }
        public string MdlName { get; set; }
        public string SubMdlName { get; set; }
        public bool? DontShowInSubDb { get; set; }
        public string FormText { get; set; }
        public string TabelMasterName { get; set; }
        public string FormTextEn { get; set; }
        public bool? Confirm { get; set; }
        public bool? CanOpen { get; set; }
        public bool? CanAdd { get; set; }
        public bool? CanUpdate { get; set; }
        public bool? CanDelete { get; set; }
        public bool? CanNavigate { get; set; }
        public bool CanPrice { get; set; }
        public bool CanUnPrice { get; set; }
        public bool CanEntry { get; set; }
        public bool CanUnEntry { get; set; }
        public bool CanPost { get; set; }
        public bool CanUnPost { get; set; }
        public bool? CanViewReport { get; set; }
        public bool CanViewJournal { get; set; }
        public bool? CanAddAttachment { get; set; }
        public bool? CanShowAttachment { get; set; }
        public string DTypeSfiledName { get; set; }
        public int? ConstDTypeG { get; set; }
        public string DocNoFiledName { get; set; }
        public string MenuId { get; set; }
        public bool? Active { get; set; }
        public bool? Visible { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }
        public bool? DontShowInSub { get; set; }
        public bool? DontUseInReport { get; set; }
        public string FieldDTypeSTable { get; set; }
        public string FieldDTypeS { get; set; }
        public string FieldDTypeSName { get; set; }
        public int? FormIndex { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual CFormConfirm CFormConfirm { get; set; }
        public virtual ContractForms ContractForms { get; set; }
        public virtual ICollection<CFormPermision> CFormPermision { get; set; }
        public virtual ICollection<PrintDocGroupFilters> PrintDocGroupFilters { get; set; }
        public virtual ICollection<PrintDocGroupGroups> PrintDocGroupGroups { get; set; }
    }
}
