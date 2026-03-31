using System;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;
using System.Drawing;

namespace SmartPowerOutageSystem.Forms
{
    public partial class NotificationsForm : Form
    {
        private readonly string _username;
        private readonly NotificationService _notifService = new NotificationService();

        public NotificationsForm(string username)
        {
            InitializeComponent();
            _username = username;
            LoadNotifications();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            lblTitle.ForeColor = Color.White;
            dgvNotifs.BackgroundColor = Color.White;
            dgvNotifs.GridColor = Color.FromArgb(241, 245, 249);
            dgvNotifs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgvNotifs.BorderStyle = BorderStyle.None;
        }

        private void LoadNotifications()
        {
            dgvNotifs.DataSource = _notifService.GetUserNotifications(_username);
            
            var colId = dgvNotifs.Columns["NotificationID"];
            if (colId != null) colId.Visible = false;
            
            var colUser = dgvNotifs.Columns["Username"];
            if (colUser != null) colUser.Visible = false;
            
            var colIsRead = dgvNotifs.Columns["IsRead"];
            if (colIsRead != null) colIsRead.Width = 60;
            
            var colDate = dgvNotifs.Columns["Date"];
            if (colDate != null) colDate.Width = 120;
            
            var colMsg = dgvNotifs.Columns["Message"];
            if (colMsg != null) colMsg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            if (dgvNotifs.SelectedRows.Count > 0)
            {
                object? val = dgvNotifs.SelectedRows[0].Cells["NotificationID"].Value;
                if (val is int id)
                {
                    _notifService.MarkAsRead(id);
                    LoadNotifications();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
