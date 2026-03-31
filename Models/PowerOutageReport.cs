using System;

namespace SmartPowerOutageSystem.Models
{
    public class PowerOutageReport : Report
    {
        public string OutageType { get; set; } = "Unknown";
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
        public DateTime? RestorationDate { get; set; }
        public string ReportedBy { get; set; } = "Anonymous";
        public string Severity { get; set; } = "Unclassified";
        public string? AssignedTechnician { get; set; }

        // Override to provide specific summary polymorphic logic
        public override string GenerateReportSummary()
        {
            var summary = $"Report #{ReportID} - {Location}\n" +
                          $"Date: {ReportDate:yyyy-MM-dd HH:mm}\n" +
                          $"Type: {OutageType} (Severity: {Severity})\n" +
                          $"Status: {Status}\n" +
                          $"Assigned: {AssignedTechnician ?? "None"}\n" +
                          $"Description: {Description}\n";

            if (RestorationDate.HasValue)
            {
                summary += $"Restored on: {RestorationDate.Value:yyyy-MM-dd HH:mm}";
            }
            else
            {
                summary += "Restoration pending.";
            }

            return summary;
        }
    }
}
