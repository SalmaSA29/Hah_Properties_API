using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MailReceiver
    {
        public string DbId1 { get; set; }
        public int MessageId { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverUser { get; set; }
        public string ReceiverDepart { get; set; }
        public DateTime? ReceiverDate { get; set; }
        public bool? Reed { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public DateTime? LocalRplDate { get; set; }
        public bool? CanUpd { get; set; }
        public bool? Deleted { get; set; }
        public bool? CompleteDelete { get; set; }
        public bool? Notify { get; set; }

        public virtual MailMessage MailMessage { get; set; }
    }
}
