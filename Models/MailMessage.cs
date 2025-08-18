using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class MailMessage
    {
        public MailMessage()
        {
            MailReceiver = new HashSet<MailReceiver>();
        }

        public string DbId1 { get; set; }
        public int MessageId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? Date { get; set; }
        public string Sender { get; set; }
        public string SourceMessage { get; set; }
        public string ToContacts { get; set; }
        public string ToDepartments { get; set; }
        public DateTime? RplDate { get; set; }
        public string DbId { get; set; }
        public DateTime? LocalRplDate { get; set; }
        public bool? CanUpd { get; set; }

        public virtual ICollection<MailReceiver> MailReceiver { get; set; }
    }
}
