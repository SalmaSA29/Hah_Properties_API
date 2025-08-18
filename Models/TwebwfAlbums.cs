using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfAlbums
    {
        public TwebwfAlbums()
        {
            TwebwfAlbumsDet = new HashSet<TwebwfAlbumsDet>();
        }

        public int AlbumId { get; set; }
        public string AlbName { get; set; }
        public string AlbDesc { get; set; }
        public DateTime? InDate { get; set; }
        public string InUser { get; set; }

        public virtual ICollection<TwebwfAlbumsDet> TwebwfAlbumsDet { get; set; }
    }
}
