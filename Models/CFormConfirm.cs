using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class CFormConfirm
    {
        public string FormId { get; set; }
        public string FormText { get; set; }
        public bool? Confirm1 { get; set; }
        public bool? Confirm2 { get; set; }
        public bool? Confirm3 { get; set; }
        public bool? Confirm4 { get; set; }
        public bool? Confirm5 { get; set; }
        public bool? Confirm6 { get; set; }
        public string Confirm1Name { get; set; }
        public string Confirm2Name { get; set; }
        public string Confirm3Name { get; set; }
        public string Confirm4Name { get; set; }
        public string Confirm5Name { get; set; }
        public string Confirm6Name { get; set; }
        public bool? Confirm1AllowTurn { get; set; }
        public bool? Confirm2AllowTurn { get; set; }
        public bool? Confirm3AllowTurn { get; set; }
        public bool? Confirm4AllowTurn { get; set; }
        public bool? Confirm5AllowTurn { get; set; }
        public bool? Confirm6AllowTurn { get; set; }
        public bool? Confirm1AllowDel { get; set; }
        public bool? Confirm2AllowDel { get; set; }
        public bool? Confirm3AllowDel { get; set; }
        public bool? Confirm4AllowDel { get; set; }
        public bool? Confirm5AllowDel { get; set; }
        public bool? Confirm6AllowDel { get; set; }
        public string InUser { get; set; }
        public string ModUser { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? ModDate { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public bool? CanUpd { get; set; }

        public virtual CForm Form { get; set; }
        public virtual CFormConfirmUserM CFormConfirmUserM { get; set; }
    }
}
