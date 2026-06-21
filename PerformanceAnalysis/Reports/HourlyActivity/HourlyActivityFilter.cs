using System;

namespace PerformanceAnalysis.Reports.HourlyActivity
{
    public class HourlyActivityFilter
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? GroupId { get; set; }
    }
}