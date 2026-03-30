using System;

namespace SmartPowerOutageSystem.Models
{
    public class PlannedOperation
    {
        public int OperationID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = "All Regions";
        public string CreatedBy { get; set; } = string.Empty;
    }
}
