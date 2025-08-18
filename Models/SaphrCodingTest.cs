using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SaphrCodingTest
    {
        public int Id { get; set; }
        public int? ComAlloc { get; set; }
        public int? Dep { get; set; }
        public int? Area { get; set; }
        public int? DepArea { get; set; }
        public int? Unit { get; set; }
        public int? Pos { get; set; }
        public int? UnitPos { get; set; }
    }
}
