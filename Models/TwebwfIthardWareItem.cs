using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfIthardWareItem
    {
        public int HardWareItemId { get; set; }
        public string ItemSerial { get; set; }
        public int TypeId { get; set; }
        public int? GroupId { get; set; }
        public int? GroupDescId { get; set; }
        public string HardWareItemName { get; set; }
        public int? MaxReq { get; set; }
        public int? MinStock { get; set; }
        public bool? RequiredEmp { get; set; }
        public string EstimatePrice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel { get; set; }
        public string DevicePorts { get; set; }
        public string DeviceMax { get; set; }
        public string ProcesType { get; set; }
        public string ProcesSpeed { get; set; }
        public string RamType { get; set; }
        public string RamSize { get; set; }
        public string Vgachipset { get; set; }
        public string Vgatype { get; set; }
        public string Vgasize { get; set; }
        public string HardType { get; set; }
        public string HardModel { get; set; }
        public string HardSize { get; set; }
        public string Windows { get; set; }
        public string ConNetWork { get; set; }
        public string ConUsb { get; set; }
        public string ConIp { get; set; }
        public string Hdtype { get; set; }
        public string Hdmodel { get; set; }
        public string Hdsize { get; set; }
        public string Comment { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }
        public string UnitType { get; set; }
        public bool? IsParent { get; set; }
        public int? ParentItemId { get; set; }
    }
}
