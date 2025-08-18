using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MainUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserImg { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string UserPhon { get; set; }
        public bool? UserGender { get; set; }
        public int GroupId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public DateTime UserInDate { get; set; }
        public int UserInUser { get; set; }
        public DateTime? UserUpDate { get; set; }
        public int? UserUpUser { get; set; }
    }
}
