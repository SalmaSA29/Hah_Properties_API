using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class TwebwfAlbumsDet
    {
        public int Id { get; set; }
        public int? AlbumId { get; set; }
        public string ImgName { get; set; }
        public string ImgDesc { get; set; }
        public bool? IsMain { get; set; }
        public DateTime? InDate { get; set; }

        public virtual TwebwfAlbums Album { get; set; }
    }
}
