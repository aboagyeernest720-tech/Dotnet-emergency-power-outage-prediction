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

            // Double-click to read full message
            dgvNotifs.CellDoubleClick += DgvNotifs_CellDoubleClick;
            dgvNotifs.SelectionChanged += DgvNotifs_SelectionChanged;
            dgvNotifs.Cursor = Cursors.Hand;
        }

        private void DgvNotifs_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNotifs.SelectedRows.Count == 0 || btnApprove == null) return;
            string msg = dgvNotifs.SelectedRows[0].Cells["Message"]?.Value?.ToString() ?? "";
            
            // Show approve button only for Manager approval requests
            btnApprove.Visible = msg.StartsWith("[AWAITING APPROVAL]");
        }

        private void ApplyTheme()
        {
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            lblTitle.ForeColor    = Color.White;
            dgvNotifs.BackgroundColor = Color.White;
            dgvNotifs.GridColor       = Color.FromArgb(241, 245, 249);
            dgvNotifs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgvNotifs.BorderStyle = BorderStyle.None;
            dgvNotifs.RowTemplate.Height = 46;

            // Hint label below grid
            var hint = new Label
            {
                Text      = "\U0001f4a1 Double-click a message to read it in full",
                Font      = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 116, 139),
                Dock      = DockStyle.Bottom,
                Height    = 28,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding   = new Padding(10, 0, 0, 0)
            };
            this.Controls.Add(hint);
            hint.BringToFront();
        }

        private void LoadNotifications()
        {
            dgvNotifs.DataSource = _notifService.GetUserNotifications(_username);

            var colId = dgvNotifs.Columns["NotificationID"];
            if (colId != null) colId.Visible = false;

            var colUser = dgvNotifs.Columns["Username"];
            if (colUser != null) colUser.Visible = false;

            var colIsRead = dgvNotifs.Columns["IsRead"];
            if (colIsRead != null) { colIsRead.Width = 65; colIsRead.HeaderText = "Read"; }

            var colDate = dgvNotifs.Columns["Date"];
            if (colDate != null) { colDate.Width = 140; colDate.HeaderText = "Received"; }

            var colMsg = dgvNotifs.Columns["Message"];
            if (colMsg != null)
            {
                colMsg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                colMsg.HeaderText   = "Notification";
            }
        }

        private void DgvNotifs_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row    = dgvNotifs.Rows[e.RowIndex];
            string msg = row.Cells["Message"]?.Value?.ToString()  ?? "";
            string dt  = row.Cells["Date"]?.Value?.ToString()     ?? "";
            object? iv = row.Cells["NotificationID"]?.Value;

            // Auto-mark as read when opened
            if (iv is int id)
            {
                _notifService.MarkAsRead(id);
                LoadNotifications();
            }

            ShowMessageDialog(msg, dt);
        }

        private void ShowMessageDialog(string message, string dateStr)
        {
            var dlg = new Form
            {
                Text            = "Notification",
                Size            = new Size(520, 300),
                FormBorderStyle = FormBorderStyle.None,
                StartPosition   = FormStartPosition.CenterParent,
                BackColor       = Color.White
            };

            // Header bar
            var hdr = new Panel { Dock = DockStyle.Top, Height = 55, BackColor = Color.FromArgb(17, 33, 51) };
            var hdrTitle = new Label
            {
                Text      = "\U0001f4ec  Full Notification",
                Font      = new Font("Segoe UI Semibold", 13F),
                ForeColor = Color.White,
                AutoSize  = true,
                Location  = new Point(16, 15)
            };
            hdr.Controls.Add(hdrTitle);
            dlg.Controls.Add(hdr);

            // Date
            var lblDate = new Label
            {
                Text      = "Received: " + dateStr,
                Font      = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location  = new Point(20, 68),
                AutoSize  = true
            };
            dlg.Controls.Add(lblDate);

            // Message body
            var txt = new RichTextBox
            {
                Text        = message,
                Font        = new Font("Segoe UI", 11F),
                ForeColor   = Color.FromArgb(30, 30, 30),
                BackColor   = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly    = true,
                ScrollBars  = RichTextBoxScrollBars.Vertical,
                Location    = new Point(20, 96),
                Size        = new Size(480, 128)
            };
            dlg.Controls.Add(txt);

            // Close button
            var btnOk = new Button
            {
                Text      = "Close",
                Font      = new Font("Segoe UI Semibold", 10F),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(100, 36),
                Location  = new Point(400, 235),
                Cursor    = Cursors.Hand
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += (s, ev) => dlg.Close();
            dlg.Controls.Add(btnOk);

            dlg.ShowDialog(this);
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

        private void btnApprove_Click(object? sender, EventArgs e)
        {
            if (dgvNotifs.SelectedRows.Count == 0) return;
            
            var row = dgvNotifs.SelectedRows[0];
            string msg = row.Cells["Message"]?.Value?.ToString() ?? "";
            object? idObj = row.Cells["NotificationID"]?.Value;

            if (msg.StartsWith("[AWAITING APPROVAL]") && idObj is int notifId)
            {
                // Format: "[AWAITING APPROVAL] Report #{id}: Status Update! Reporter: {reportedBy} | Location: {location} | New Status: {status}"
                try
                {
                    int repoIdIdx = msg.IndexOf("Report #") + "Report #".Length;
                    int repoIdEnd = msg.IndexOf(":", repoIdIdx);
                    string reportId = msg.Substring(repoIdIdx, repoIdEnd - repoIdIdx).Trim();

                    int reporterIdx = msg.IndexOf("Reporter: ") + "Reporter: ".Length;
                    int locIdx = msg.IndexOf(" | Location: ");
                    string reporter = msg.Substring(reporterIdx, locIdx - reporterIdx).Trim();

                    int locEndIdx = msg.IndexOf(" | New Status: ");
                    string location = msg.Substring(locIdx + " | Location: ".Length, locEndIdx - (locIdx + " | Location: ".Length)).Trim();
                    string status = msg.Substring(locEndIdx + " | New Status: ".Length).Trim();

                    string messageToReporter = $"Outage Update: We apologize for the outage experienced earlier at {location}. The issue (# {reportId}) has now been fixed and electricity supply restored. Status: {status}.";
                    
                    if (reporter != "Anonymous")
                    {
                        _notifService.SendNotification(reporter, messageToReporter);
                        MessageBox.Show("Approval acknowledged. The original reporter has been notified.", "Status Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Status update approved. Reporter was anonymous, so no user notification sent.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    // Mark the manager's approval notification as read
                    _notifService.MarkAsRead(notifId);
                    LoadNotifications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not parse notification details for approval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
