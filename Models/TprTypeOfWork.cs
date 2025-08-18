using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TprTypeOfWork
    {
        public TprTypeOfWork()
        {
            TprBoqD = new HashSet<TprBoqD>();
        }

        public string TypeOfWorkId { get; set; }
        public string TypeOfWork { get; set; }
        public string InUser { get; set; }
        public DateTime? InDate { get; set; }
        public string ModUser { get; set; }
        public DateTime? ModDate { get; set; }
        public string DbId { get; set; }

        public virtual ICollection<TprBoqD> TprBoqD { get; set; }
    }
}
