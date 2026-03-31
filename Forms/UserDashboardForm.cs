using System;
using System.Drawing;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class UserDashboardForm : Form
    {
        private string _username;
        private string _location;
        private UserService _userService = new UserService();
        private OperationService _operationService = new OperationService();

        public UserDashboardForm(string username)
        {
            InitializeComponent();
            _username = username;
            _location = _userService.GetUserLocation(_username);
            lblWelcome.Text = $"Welcome, {_username}";
            lblLocation.Text = $"Location: {_location}";
            CheckStatus();
        }

        private void CheckStatus()
        {
            try
            {
                var latestOp = _operationService.GetLatestOperationForUser(_location);
                if (latestOp != null)
                {
                    lblStatus.Text = "⚠️ PLANNED OUTAGE SOON";
                    lblStatus.ForeColor = Color.Orange;
                    lblNotifDate.Text = $"{latestOp.StartDate.ToString("MMM dd, HH:mm")} - {latestOp.EndDate.ToString("HH:mm")}";
                    lblNotifTitle.Text = latestOp.Title;
                    pnlNotif.Visible = true;
                }
                else
                {
                    lblStatus.Text = "✅ POWER ONLINE";
                    lblStatus.ForeColor = Color.FromArgb(46, 204, 113);
                    pnlNotif.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking status: " + ex.Message);
            }
            UpdateNotificationBadge();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new OutageReportForm(_username).ShowDialog();
            CheckStatus();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            using (var form = new NotificationsForm(_username))
            {
                form.ShowDialog();
            }
            CheckStatus();
        }

        private void UpdateNotificationBadge()
        {
            var notifService = new NotificationService();
            int unread = notifService.GetUnreadCount(_username);
            if (unread > 0)
            {
                btnNotifications.Text = $"🔔 Notifications ({unread})";
                btnNotifications.ForeColor = Color.Yellow;
            }
            else
            {
                btnNotifications.Text = "🔔 Notifications";
                btnNotifications.ForeColor = Color.White;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm(_username))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _username = form.CurrentUsername;
                    _location = _userService.GetUserLocation(_username);
                    lblWelcome.Text = $"Welcome, {_username}";
                    lblLocation.Text = $"Location: {_location}";
                    CheckStatus();
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
            CheckStatus();
        }
    }
}
