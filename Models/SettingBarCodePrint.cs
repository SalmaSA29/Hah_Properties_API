using System;
using System.Collections.Generic;

namespace PortalAPI.Models
{
    public partial class SettingBarCodePrint
    {
        public int Serial { get; set; }
        public string PaperType { get; set; }
        public double TopMargin { get; set; }
        public double SideMargin { get; set; }
        public double HorizontalSpacing { get; set; }
        public double VerticalSpacing { get; set; }
        public double PageWidth { get; set; }
        public double PageHeight { get; set; }
        public double BarCodeHeight { get; set; }
        public double NarrowWidth { get; set; }
        public double Columns { get; set; }
        public double Rows { get; set; }
        public double LabelHeight { get; set; }
        public double LabelWidth { get; set; }
        public double Count { get; set; }
    }
}
