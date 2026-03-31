using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Data;
using SmartPowerOutageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace SmartPowerOutageSystem.Services
{
    public class NotificationService
    {
        public bool SendNotification(string username, string message)
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Notifications (Username, Message, Date, IsRead) VALUES (@u, @m, @d, 0)";
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@m", message);
                cmd.Parameters.AddWithValue("@d", DateTime.Now);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Notification error: {ex.Message}");
                return false;
            }
        }

        public bool SendNotificationToLocation(string location, string message)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            // Find all users in location
            var cmdUsers = connection.CreateCommand();
            cmdUsers.CommandText = "SELECT Username FROM Users WHERE Location = @loc OR @loc = 'All'";
            cmdUsers.Parameters.AddWithValue("@loc", location);
            
            var users = new List<string>();
            using (var reader = cmdUsers.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.Add(reader.GetString(0));
                }
            }

            int count = 0;
            foreach(var u in users)
            {
                if (SendNotification(u, message)) count++;
            }
            return count > 0;
        }

        public List<Notification> GetUserNotifications(string username)
        {
            var list = new List<Notification>();
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                connection.Open();

                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Notifications WHERE Username = @u ORDER BY Date DESC";
                cmd.Parameters.AddWithValue("@u", username);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Notification
                    {
                        NotificationID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Message = reader.GetString(2),
                        Date = reader.GetDateTime(3),
                        IsRead = reader.GetBoolean(4)
                    });
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Load notifications error: {ex.Message}");
            }
            return list;
        }

        public bool MarkAsRead(int notificationId)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Notifications SET IsRead = 1 WHERE NotificationID = @id";
            cmd.Parameters.AddWithValue("@id", notificationId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public int GetUnreadCount(string username)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Notifications WHERE Username = @u AND IsRead = 0";
            cmd.Parameters.AddWithValue("@u", username);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
