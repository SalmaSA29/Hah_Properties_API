using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class InjuredPerson
    {
        public int InjuredpersonId { get; set; }
        public string IncidentId { get; set; }
        public string Fullname { get; set; }
        public string Sex { get; set; }
        public string Occupation { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Fullresidentialaddress { get; set; }
        public DateTime? Datehired { get; set; }
        public DateTime? Dateemployernotifiedofinjury { get; set; }
        public string Employmentcategory { get; set; }
        public string Howlonginpresentjob { get; set; }
        public string Employeesproject { get; set; }
        public string Employeehomeoffice { get; set; }
        public string Injurytype { get; set; }
        public string Natureofinjury { get; set; }
        public string Partofbodyinjured { get; set; }
        public string Persondoingjustbeforetheincident { get; set; }
        public string Whathappened { get; set; }
        public string Harmedtheemployee { get; set; }
        public string Whereinjuriestreated { get; set; }
        public string Whoprovidedtreatment { get; set; }
        public string Treatmentgiven { get; set; }
        public string Hasinjuredemployeereturnedtowork { get; set; }
    }
}
