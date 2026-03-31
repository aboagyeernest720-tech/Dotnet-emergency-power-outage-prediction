using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Data;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System;

namespace SmartPowerOutageSystem.Services
{
    public class UserService
    {
        public bool Authenticate(string username, string password)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Password FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);

            var storedHash = cmd.ExecuteScalar()?.ToString();
            if (storedHash == null) return false;

            return VerifyPassword(password, storedHash);
        }

        public string GetUserRole(string username)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Role FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);

            return cmd.ExecuteScalar()?.ToString() ?? "Guest";
        }

        public string GetUserLocation(string username)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Location FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);

            return cmd.ExecuteScalar()?.ToString() ?? "Unknown";
        }

        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT UserID, Username, Role FROM Users ORDER BY Username";

            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public List<string> GetUsersByRole(string role)
        {
            var list = new List<string>();
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Username FROM Users WHERE Role = @r ORDER BY Username";
            cmd.Parameters.AddWithValue("@r", role);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        public bool SaveUser(string username, string password, string role, string location = "Unknown")
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            // Check if user exists
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);
            
            var result = cmd.ExecuteScalar();
            long exists = result != null ? System.Convert.ToInt64(result) : 0;
            cmd.Parameters.Clear();

            if (exists > 0)
            {
                // Update
                cmd.CommandText = "UPDATE Users SET Password = @p, Role = @r, Location = @loc WHERE Username = @u";
            }
            else
            {
                // Insert
                cmd.CommandText = "INSERT INTO Users (Username, Password, Role, Location) VALUES (@u, @p, @r, @loc)";
            }

            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", HashPassword(password));
            cmd.Parameters.AddWithValue("@r", role);
            cmd.Parameters.AddWithValue("@loc", location);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteUser(string username)
        {
            if (username.Equals("admin", System.StringComparison.OrdinalIgnoreCase)) return false; // Basic protection

            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool UpdatePassword(string username, string newPassword)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET Password = @p WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", HashPassword(newPassword));

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateUsername(string oldUsername, string newUsername)
        {
            if (UserExists(newUsername) && !oldUsername.Equals(newUsername, System.StringComparison.OrdinalIgnoreCase))
                return false;

            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Users SET Username = @new WHERE Username = @old";
            cmd.Parameters.AddWithValue("@new", newUsername);
            cmd.Parameters.AddWithValue("@old", oldUsername);

            return cmd.ExecuteNonQuery() > 0;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            return HashPassword(inputPassword) == storedHash;
        }
        public bool UserExists(string username)
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @u";
            cmd.Parameters.AddWithValue("@u", username);

            var result = cmd.ExecuteScalar();
            return Convert.ToInt64(result) > 0;
        }
        public int GetUserCount()
        {
            using var connection = DatabaseHelper.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users";

            var result = cmd.ExecuteScalar();
            return result != null ? System.Convert.ToInt32(result) : 0;
        }
    }
}
