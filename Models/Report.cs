using System;

namespace SmartPowerOutageSystem.Models
{
    public abstract class Report
    {
        public int ReportID { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime ReportDate { get; set; } = DateTime.Now;

        // The method to be overridden as per polymorphic requirements
        public abstract string GenerateReportSummary();
    }
}
