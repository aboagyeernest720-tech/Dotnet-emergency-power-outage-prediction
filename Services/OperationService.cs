using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Data;
using SmartPowerOutageSystem.Models;
using System.Collections.Generic;
using System;

namespace SmartPowerOutageSystem.Services
{
    public class OperationService
    {
        public bool AddPlannedOperation(PlannedOperation operation)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO PlannedOperations (Title, Description, StartDate, EndDate, Location, CreatedBy)
                VALUES (@title, @desc, @start, @end, @loc, @by)
            ";
            cmd.Parameters.AddWithValue("@title", operation.Title);
            cmd.Parameters.AddWithValue("@desc", operation.Description);
            cmd.Parameters.AddWithValue("@start", operation.StartDate);
            cmd.Parameters.AddWithValue("@end", operation.EndDate);
            cmd.Parameters.AddWithValue("@loc", operation.Location);
            cmd.Parameters.AddWithValue("@by", operation.CreatedBy);

            return cmd.ExecuteNonQuery() > 0;
        }

        public List<PlannedOperation> GetAllOperations()
        {
            var operations = new List<PlannedOperation>();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM PlannedOperations ORDER BY StartDate DESC";
            
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                operations.Add(new PlannedOperation
                {
                    OperationID = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    StartDate = reader.GetDateTime(3),
                    EndDate = reader.GetDateTime(4),
                    Location = reader.IsDBNull(5) ? "All Regions" : reader.GetString(5),
                    CreatedBy = reader.IsDBNull(6) ? "System" : reader.GetString(6)
                });
            }
            return operations;
        }

        public PlannedOperation? GetLatestOperationForUser(string location)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT TOP 1 * FROM PlannedOperations 
                WHERE (Location = @loc OR Location = 'All Regions') 
                AND StartDate >= GETDATE()
                ORDER BY StartDate ASC";
            cmd.Parameters.AddWithValue("@loc", location);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new PlannedOperation
                {
                    OperationID = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    StartDate = reader.GetDateTime(3),
                    EndDate = reader.GetDateTime(4),
                    Location = reader.IsDBNull(5) ? "All Regions" : reader.GetString(5),
                    CreatedBy = reader.IsDBNull(6) ? "System" : reader.GetString(6)
                };
            }
            return null;
        }

        public bool DeleteOperation(int id)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM PlannedOperations WHERE OperationID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
