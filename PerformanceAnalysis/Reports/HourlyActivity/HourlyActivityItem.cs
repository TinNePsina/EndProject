namespace PerformanceAnalysis.Reports.HourlyActivity
{
    public class HourlyActivityItem
    {
        public int Hour { get; set; }
        public int TestsCompleted { get; set; }
        public int UniqueScudents { get; set; } // Оставляем опечатку Scudents для совместимости с базой автора
    }
}