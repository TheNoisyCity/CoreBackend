using System;
using System.Collections.Generic;

namespace CoreBackend.Models
{
    public partial class Report
    {
        public long Reportid { get; set; }
        public long Rid { get; set; }
        public long Reporter { get; set; }
        public long Reportee { get; set; }
        public DateTimeOffset ReportTime { get; set; }
        public string Reason { get; set; }
    }
}
