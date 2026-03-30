using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Data;
using SmartPowerOutageSystem.Models;
using System.Collections.Generic;
using System;
using System.Data;

namespace SmartPowerOutageSystem.Services
{
    public class OutageService
    {
        public bool SaveReport(PowerOutageReport report)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO OutageReports (Location, ReportDate, OutageType, Description, Status, ReportedBy)
                VALUES (@loc, @date, @type, @desc, @stat, @by)
            ";
            cmd.Parameters.AddWithValue("@loc", report.Location);
            cmd.Parameters.AddWithValue("@date", report.ReportDate);
            cmd.Parameters.AddWithValue("@type", report.OutageType);
            cmd.Parameters.AddWithValue("@desc", report.Description);
            cmd.Parameters.AddWithValue("@stat", report.Status);
            cmd.Parameters.AddWithValue("@by", report.ReportedBy);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<PowerOutageReport> GetAllReports()
        {
            var reports = new List<PowerOutageReport>();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM OutageReports ORDER BY ReportDate DESC";
            
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                reports.Add(new PowerOutageReport
                {
                    ReportID = reader.GetInt32(0),
                    Location = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1),
                    ReportDate = reader.IsDBNull(2) ? DateTime.Now : reader.GetDateTime(2),
                    OutageType = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3),
                    Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Status = reader.IsDBNull(5) ? "Pending" : reader.GetString(5),
                    RestorationDate = reader.IsDBNull(6) ? null : reader.GetDateTime(6),
                    ReportedBy = reader.IsDBNull(7) ? "Anonymous" : reader.GetString(7)
                });
            }
            return reports;
        }

        public bool UpdateStatus(int id, string status, DateTime? restorationDate = null)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE OutageReports SET Status = @s, RestorationDate = @r WHERE ReportID = @id";
            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@r", (object?)restorationDate ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteReport(int id)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM OutageReports WHERE ReportID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }
        public DataTable GetRestorationData()
        {
            DataTable dt = new DataTable();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Location, ReportDate, RestorationDate, Status FROM OutageReports WHERE Status = 'Restored' ORDER BY RestorationDate DESC";

            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            
            // Note: In memory calculation for duration since SQLite text dates are tricky to diff via SQL in a simple way
            return dt;
        }

        public Dictionary<string, string> GetStatistics()
        {
            var stats = new Dictionary<string, string>();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            
            // Total
            cmd.CommandText = "SELECT COUNT(*) FROM OutageReports";
            stats["TotalOutages"] = cmd.ExecuteScalar()?.ToString() ?? "0";

            // Restored
            cmd.CommandText = "SELECT COUNT(*) FROM OutageReports WHERE Status = 'Restored'";
            stats["RestoredOutages"] = cmd.ExecuteScalar()?.ToString() ?? "0";

            // Unrestored (Pending/In Progress)
            cmd.CommandText = "SELECT COUNT(*) FROM OutageReports WHERE Status != 'Restored'";
            stats["ActiveOutages"] = cmd.ExecuteScalar()?.ToString() ?? "0";

            // Top Location
            cmd.CommandText = "SELECT TOP 1 Location FROM OutageReports GROUP BY Location ORDER BY COUNT(*) DESC";
            stats["TopLocation"] = cmd.ExecuteScalar()?.ToString() ?? "N/A";

            return stats;
        }

        public string PredictNextOutage()
        {
            // Simple logic: If last 3 outages were in the same area recently, predict that area.
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT TOP 5 Location FROM OutageReports ORDER BY ReportDate DESC";
            using var reader = cmd.ExecuteReader();
            
            var locations = new List<string>();
            while (reader.Read()) locations.Add(reader.GetString(0));

            if (locations.Count >= 3)
            {
                // Check if any location repeats
                var prediction = locations.GroupBy(l => l).OrderByDescending(g => g.Count()).First().Key;
                return $"High probability of outage in: {prediction} (Based on recent trends)";
            }
            return "Insufficient data for reliable prediction.";
        }

        public DataTable GetOutageTypeStats()
        {
            DataTable dt = new DataTable();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT OutageType, COUNT(*) as Count FROM OutageReports GROUP BY OutageType ORDER BY Count DESC";
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public DataTable GetOutagesPerLocation()
        {
            DataTable dt = new DataTable();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Location, COUNT(*) as Count FROM OutageReports GROUP BY Location ORDER BY Count DESC";
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }
    }
}
