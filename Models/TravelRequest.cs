using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalAPI.Models
{
    public class TravelRequest
    {
      
            public int RequestNo { get; set; }
            public string ServiceID { get; set; }
            public string RequestType { get; set; }
            public string RequestHRCode { get; set; }
            public DateTime? RequestDate { get; set; }
            public string OwnerHrCode { get; set; }
            public string OwnerLocation { get; set; }
            public string OwnerProjectManager { get; set; }
            public string OwnerprojectDirector { get; set; }
            public string OwnerFirstname { get; set; }
            public string OwnerLastname { get; set; }
            public string OwnerMiddlename { get; set; }
            public string OwnerTitle { get; set; }
            public string OwnerNationality { get; set; }
            public string OwnerPassno { get; set; }
            public DateTime? Ownerpassexpirydate { get; set; }
            public string Travelfrom { get; set; }
            public string Travelto { get; set; }
            public DateTime? Depurturedate { get; set; }
            public DateTime? Returndate { get; set; }
            public string Travelreason { get; set; }
            public string costallocation { get; set; }
            public bool? AirTicket { get; set; }
            public bool? HotelBooking { get; set; }
            public bool? Visa { get; set; }
            public string AirTicketcostperunit { get; set; }
            public string AirTicketTotalcost { get; set; }
            public string AirTicketvedor { get; set; }
            public string Hotelbookingcostperunit { get; set; }
            public string Hotelbookingtotalcost { get; set; }
            public string Visacostperunit { get; set; }
            public string VisaTotalcost { get; set; }
            public string perdiemcostperunit { get; set; }
            public string perdiemtotalcost { get; set; }
            public string othercostperunit { get; set; }
            public string othertotalcost { get; set; }
            public string totalapproxcostperunit { get; set; }
            public string totalapproxtotalcost { get; set; }
            public string attach1 { get; set; }
            public string attach2 { get; set; }
            public string attach3 { get; set; }
            public string attach4 { get; set; }
            public string attach5 { get; set; }
            public string Inuser { get; set; }
            public DateTime? Indate { get; set; }
            public int? Status { get; set; }
            public DateTime? ClosedDate { get; set; }
            public bool? MeetAssist { get; set; }
            public string partners { get; set; }
            public bool? Insurance { get; set; }
            public bool? Car { get; set; }
            public bool? Train { get; set; }
            public string Comments { get; set; }
        
    }
}
