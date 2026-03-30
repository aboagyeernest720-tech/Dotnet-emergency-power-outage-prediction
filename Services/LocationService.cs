using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Data;
using System.Collections.Generic;
using System.Data;

namespace SmartPowerOutageSystem.Services
{
    public class LocationService
    {
        public DataTable GetAllLocations()
        {
            DataTable dt = new DataTable();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Locations ORDER BY LocationName";

            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public bool SaveLocation(string name, string region)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO Locations (LocationName, Region) VALUES (@n, @r)";
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@r", region);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteLocation(int id)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Locations WHERE LocationID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
