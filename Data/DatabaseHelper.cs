using Microsoft.Data.SqlClient;
using SmartPowerOutageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace SmartPowerOutageSystem.Data
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=SmartPowerOutageSystem;Trusted_Connection=True;Encrypt=False;";

        public static void InitializeDatabase()
        {
            // First check if database exists, create if it doesn't
            using (var masterConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;Encrypt=False;"))
            {
                masterConnection.Open();
                var cmdCheck = masterConnection.CreateCommand();
                cmdCheck.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'SmartPowerOutageSystem') CREATE DATABASE SmartPowerOutageSystem;";
                cmdCheck.ExecuteNonQuery();
            }

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();

            // Create OutageReports table
            var cmdOutageReport = connection.CreateCommand();
            cmdOutageReport.CommandText = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OutageReports')
                CREATE TABLE OutageReports (
                    ReportID INT PRIMARY KEY IDENTITY(1,1),
                    Location NVARCHAR(MAX) NOT NULL,
                    ReportDate DATETIME NOT NULL,
                    OutageType NVARCHAR(MAX),
                    Description NVARCHAR(MAX),
                    Status NVARCHAR(MAX) DEFAULT 'Pending',
                    RestorationDate DATETIME,
                    ReportedBy NVARCHAR(MAX)
                );
            ";
            cmdOutageReport.ExecuteNonQuery();

            // Create Users table for login
            var cmdUsers = connection.CreateCommand();
            cmdUsers.CommandText = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
                CREATE TABLE Users (
                    UserID INT PRIMARY KEY IDENTITY(1,1),
                    Username NVARCHAR(255) NOT NULL UNIQUE,
                    Password NVARCHAR(MAX) NOT NULL,
                    Role NVARCHAR(MAX) NOT NULL,
                    Location NVARCHAR(MAX)
                );
            ";
            cmdUsers.ExecuteNonQuery();

            // Create Locations table
            var cmdLocations = connection.CreateCommand();
            cmdLocations.CommandText = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Locations')
                CREATE TABLE Locations (
                    LocationID INT PRIMARY KEY IDENTITY(1,1),
                    LocationName NVARCHAR(255) NOT NULL UNIQUE,
                    Region NVARCHAR(MAX)
                );
            ";
            cmdLocations.ExecuteNonQuery();

            // Create PlannedOperations table
            var cmdOperations = connection.CreateCommand();
            cmdOperations.CommandText = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'PlannedOperations')
                CREATE TABLE PlannedOperations (
                    OperationID INT PRIMARY KEY IDENTITY(1,1),
                    Title NVARCHAR(MAX) NOT NULL,
                    Description NVARCHAR(MAX),
                    StartDate DATETIME NOT NULL,
                    EndDate DATETIME NOT NULL,
                    Location NVARCHAR(MAX),
                    CreatedBy NVARCHAR(MAX)
                );
            ";
            cmdOperations.ExecuteNonQuery();
            
            // Create Notifications table
            var cmdNotifications = connection.CreateCommand();
            cmdNotifications.CommandText = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Notifications')
                CREATE TABLE Notifications (
                    NotificationID INT PRIMARY KEY IDENTITY(1,1),
                    Username NVARCHAR(255) NOT NULL,
                    Message NVARCHAR(MAX) NOT NULL,
                    Date DATETIME DEFAULT GETDATE(),
                    IsRead BIT DEFAULT 0
                );
            ";
            cmdNotifications.ExecuteNonQuery();

            // Seed 16 Regions of Ghana
            string[] ghanaregions = { 
                "Greater Accra Region", "Ashanti Region", "Western Region", "Eastern Region", "Central Region", 
                "Volta Region", "Northern Region", "Upper East Region", "Upper West Region", "Savannah Region", 
                "North East Region", "Bono Region", "Bono East Region", "Ahafo Region", "Oti Region", "Western North Region" 
            };
            
            foreach (var region in ghanaregions)
            {
                var cmdSeedLoc = connection.CreateCommand();
                cmdSeedLoc.CommandText = "IF NOT EXISTS (SELECT 1 FROM Locations WHERE LocationName = @n) INSERT INTO Locations (LocationName, Region) VALUES (@n, @r);";
                cmdSeedLoc.Parameters.AddWithValue("@n", region);
                cmdSeedLoc.Parameters.AddWithValue("@r", "Ghana");
                cmdSeedLoc.ExecuteNonQuery();
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
