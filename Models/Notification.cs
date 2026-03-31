using System;

namespace SmartPowerOutageSystem.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
    }
}
