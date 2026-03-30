using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private string _username;
        private string _role;
        private UserService _userService = new UserService();
        private OutageService _outageService = new OutageService();
        private OperationService _operationService = new OperationService();

        public AdminDashboardForm(string username)
        {
            InitializeComponent();
            _username = username;
            _role = "Administrator";
            lblWelcome.Text = $"Welcome, Admin {_username}";
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                var stats = _outageService.GetStatistics();
                lblTotalReports.Text = stats.ContainsKey("TotalOutages") ? stats["TotalOutages"] : "0";
                lblActiveOutages.Text = stats.ContainsKey("ActiveOutages") ? stats["ActiveOutages"] : "0";
                lblTotalUsers.Text = _userService.GetUserCount().ToString();
                lblPrediction.Text = _outageService.PredictNextOutage();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading stats: " + ex.Message);
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagementForm().ShowDialog();
            LoadStatistics();
        }

        private void btnLocationManagement_Click(object sender, EventArgs e)
        {
            new LocationManagementForm().ShowDialog();
        }

        private void btnOutageRecords_Click(object sender, EventArgs e)
        {
            new OutageRecordsForm(_role).ShowDialog();
            LoadStatistics();
        }

        private void btnPlannedOperations_Click(object sender, EventArgs e)
        {
            new PlannedOperationsForm(_role, _username).ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new OutageStatisticsForm().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm(_username))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _username = form.CurrentUsername;
                    lblWelcome.Text = $"Welcome, Admin {_username}";
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }
    }
}
