using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private DataTable? _chartData;

        // Dashboard Data
        private int _totalOutages = 0;
        private int _pending = 0;
        private int _resolved = 0;
        private int _today = 0;

        public AdminDashboardForm(string username, string role = "Administrator")
        {
            InitializeComponent();
            _username = username;
            _role = role;
            lblWelcome.Text = $"👤 Welcome, {role}";

            // Role-Based Access Control
            // Admins manage the system; they do not report outages
            btnReport.Visible = false;

            if (_role == "Manager")
            {
                btnReport.Visible = true;
                btnReport.Click -= btnReport_Click;
                btnReport.Click += btnNotifications_Click;

                btnUsers.Text = "📢  Planned Activity";
                btnUsers.Click -= btnUserManagement_Click;
                btnUsers.Click += btnPlannedActivity_Click;

                btnLocations.Text = "📄  Download Report";
                btnLocations.Click -= btnLocationManagement_Click;
                btnLocations.Click += btnDownloadReport_Click;
            }
            else if (_role == "Dispatcher")
            {
                btnReport.Visible = true;
                btnReport.Click -= btnReport_Click;
                btnReport.Click += btnNotifications_Click;

                btnUsers.Visible = false;
                btnLocations.Visible = false;
                btnStats.Visible = false;
                btnReports.Text = "📡 Dispatch Center";
            }
            else if (_role == "Technician")
            {
                btnReport.Visible = true;
                btnReport.Click -= btnReport_Click;
                btnReport.Click += btnNotifications_Click;

                btnUsers.Visible = false;
                btnLocations.Visible = false;
                btnReports.Text = "🔧 My Assigned Tasks";
                btnStats.Text = "📝 Update Task Status";
            }

            ConfigureGrids();
            LoadStatistics();
            UpdateNotificationBadge();
            
            // Re-render sizes correctly
            this.Resize += (s, e) => { Invalidate(true); };
        }

        private void ConfigureGrids()
        {
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRecent.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.ReadOnly = true;
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.RowTemplate.Height = 40;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.GridColor = Color.FromArgb(240, 240, 240);

            dgvRecent.CellPainting += DgvRecent_CellPainting;
            dgvRecent.DataBindingComplete += (s, e) => {
                dgvRecent.ClearSelection();
                var colId = dgvRecent.Columns["ID"];
                if (colId != null) { colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; colId.Width = 40; }

                var colLoc = dgvRecent.Columns["Location"];
                if (colLoc != null) { colLoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; colLoc.FillWeight = 100; }

                var colDate = dgvRecent.Columns["Date"];
                if (colDate != null) { colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; colDate.FillWeight = 110; colDate.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; }

                var colStatus = dgvRecent.Columns["Status"];
                if (colStatus != null) { colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; colStatus.Width = 120; }
            };
        }

        private void DgvRecent_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRecent.Columns[e.ColumnIndex]?.Name == "Status")
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                string status = e.Value?.ToString() ?? "";
                Color bgColor = Color.White;
                Color fgColor = Color.Black;

                if (status == "Pending")
                {
                    bgColor = Color.FromArgb(254, 236, 220); // light orange
                    fgColor = Color.FromArgb(217, 119, 6);   // dark orange
                }
                else if (status == "Resolved" || status == "Restored")
                {
                    bgColor = Color.FromArgb(209, 250, 229); // light green
                    fgColor = Color.FromArgb(5, 150, 105);   // dark green
                }
                else if (status == "Investigating")
                {
                    bgColor = Color.FromArgb(219, 234, 254);
                    fgColor = Color.FromArgb(37, 99, 235);
                }

                // Draw pill
                var cellFont = e.CellStyle?.Font ?? this.Font;
                int pillWidth = (int)(e.Graphics?.MeasureString(status, cellFont).Width ?? 0) + 24;
                int pillHeight = 26;
                int x = e.CellBounds.Left + 5;
                int y = e.CellBounds.Top + (e.CellBounds.Height - pillHeight) / 2;

                using (GraphicsPath path = GetRoundedRectPath(new Rectangle(x, y, pillWidth, pillHeight), 12))
                using (SolidBrush brush = new SolidBrush(bgColor))
                if (e.Graphics != null)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(brush, path);
                }

                // Draw text
                using (SolidBrush textBrush = new SolidBrush(fgColor))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    e.Graphics?.DrawString(status, cellFont, textBrush, new Rectangle(x, y, pillWidth, pillHeight), sf);
                }
            }
            else
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            }
            
            // Draw custom light grid line
            using (Pen p = new Pen(Color.FromArgb(243, 244, 246)))
            {
                e.Graphics?.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }
        }

        private void LoadStatistics()
        {
            try
            {
                string? techFilter = (_role == "Technician") ? _username : null;

                var counts = _outageService.GetDashboardCounts(techFilter);
                _totalOutages = counts["Total"];
                _pending = counts["Pending"];
                _resolved = counts["Resolved"];
                _today = counts["Today"];

                dgvRecent.DataSource = _outageService.GetRecentReports(4, techFilter, true); 
                _chartData = _outageService.GetTopLocationsForChart(5, techFilter);
                
                lblRecentTitle.Text = "Today's Outage Reports";
                
                // Refresh paintings
                pnlCards.Invalidate(true);
                pnlChart.Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading stats: " + ex.Message);
            }
        }

        private void pnlCards_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Dynamically calculate card size based on panel width
            int spacing = 14;
            int startX = 8;
            int totalSpacing = startX + (spacing * 3) + 8;
            int cardW = (pnlCards.Width - totalSpacing) / 4;
            int cardH = pnlCards.Height - 12;

            // Professional card accent colors
            string totalLabel = (_role == "Technician") ? "Total Assignments" : "Total Complaints";

            DrawCard(g, new Rectangle(startX, 4, cardW, cardH), totalLabel, _totalOutages.ToString("D2"),
                Color.FromArgb(26, 86, 219), Color.FromArgb(147, 197, 253), "⚡");
            DrawCard(g, new Rectangle(startX + (cardW+spacing)*1, 4, cardW, cardH), "Pending", _pending.ToString("D2"),
                Color.FromArgb(217, 119, 6), Color.FromArgb(252, 211, 77), "🕒");
            DrawCard(g, new Rectangle(startX + (cardW+spacing)*2, 4, cardW, cardH), "Resolved", _resolved.ToString("D2"),
                Color.FromArgb(4, 120, 87), Color.FromArgb(52, 211, 153), "✅");
            DrawCard(g, new Rectangle(startX + (cardW+spacing)*3, 4, cardW, cardH), "Today's Reports", _today.ToString("D2"),
                Color.FromArgb(7, 148, 136), Color.FromArgb(94, 234, 212), "📅");
        }

        private void DrawCard(Graphics g, Rectangle bounds, string title, string value, Color accentDark, Color accentLight, string icon)
        {
            // Soft shadow
            using (GraphicsPath shadowPath = GetRoundedRectPath(new Rectangle(bounds.X + 3, bounds.Y + 5, bounds.Width - 4, bounds.Height - 4), 12))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                g.FillPath(shadowBrush, shadowPath);

            // Card background - white
            var cardRect = new Rectangle(bounds.X, bounds.Y, bounds.Width - 4, bounds.Height - 4);
            using (GraphicsPath path = GetRoundedRectPath(cardRect, 12))
            using (SolidBrush bgBrush = new SolidBrush(Color.White))
                g.FillPath(bgBrush, path);

            // Left accent bar
            var accentBar = new Rectangle(cardRect.X, cardRect.Y, 5, cardRect.Height);
            using (GraphicsPath accentPath = GetRoundedRectPath(accentBar, 4))
            using (LinearGradientBrush accentBrush = new LinearGradientBrush(
                new Point(accentBar.X, accentBar.Y), new Point(accentBar.X, accentBar.Bottom),
                accentDark, accentLight))
                g.FillPath(accentBrush, accentPath);

            // Icon circle
            int circleSize = 48;
            int circleX = cardRect.X + 20;
            int circleY = cardRect.Y + (cardRect.Height - circleSize) / 2;
            var circleRect = new Rectangle(circleX, circleY, circleSize, circleSize);
            using (LinearGradientBrush iconBg = new LinearGradientBrush(
                new Point(circleX, circleY), new Point(circleX + circleSize, circleY + circleSize),
                accentDark, accentLight))
                g.FillEllipse(iconBg, circleRect);
            
            using (Font fIcon = new Font("Segoe UI Emoji", 18))
            using (SolidBrush wBrush = new SolidBrush(Color.White))
            using (StringFormat sf = new StringFormat{Alignment = StringAlignment.Center, LineAlignment=StringAlignment.Center})
                g.DrawString(icon, fIcon, wBrush, circleRect, sf);

            // Title text
            int textX = circleX + circleSize + 12;
            using (Font fTitle = new Font("Segoe UI", 9f))
            using (SolidBrush bTitle = new SolidBrush(Color.FromArgb(100, 116, 139)))
                g.DrawString(title, fTitle, bTitle, textX, cardRect.Y + 20);

            // Value text
            using (Font fVal = new Font("Segoe UI", 24, FontStyle.Bold))
            using (SolidBrush bVal = new SolidBrush(accentDark))
                g.DrawString(value, fVal, bVal, textX, cardRect.Y + 40);
        }

        private void pnlRecent_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBox(e.Graphics, pnlRecent.ClientRectangle);
        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DrawPanelBox(g, pnlChart.ClientRectangle);

            if (_chartData == null || _chartData.Rows.Count == 0) return;

            int maxCount = 5;
            foreach (System.Data.DataRow row in _chartData.Rows)
                maxCount = Math.Max(maxCount, Convert.ToInt32(row["Count"]));
            
            // Generate a better Y-axis scale block size
            int stepSize = 1;
            if (maxCount > 10) stepSize = 5;
            if (maxCount > 50) stepSize = 10;
            if (maxCount > 100) stepSize = 25;

            // Round maxCount up to the nearest logical grid step
            maxCount = ((maxCount + (stepSize - 1)) / stepSize) * stepSize;

            int chartH = 220;
            int startX = 35;
            int startY = 270; 
            int barWidth = 35; 
            int spacing = 35;

            // Draw horizontal grid lines
            using (Pen gridPen = new Pen(Color.FromArgb(220, 220, 220)))
            {
                gridPen.DashStyle = DashStyle.Dash;
                using (Font fAx = new Font("Segoe UI", 8.5f))
                for (int i = 0; i <= maxCount; i += stepSize)
                {
                    int y = startY - (int)((double)i / maxCount * chartH);
                    g.DrawString(i.ToString(), fAx, Brushes.Black, 10, y - 6);
                    g.DrawLine(gridPen, startX, y, pnlChart.Width - 20, y);
                }
            }

            Color[] colors = {
                Color.FromArgb(26, 86, 219),  // Corporate Blue
                Color.FromArgb(4, 120, 87),   // Emerald Green
                Color.FromArgb(217, 119, 6),  // Amber
                Color.FromArgb(7, 148, 136),  // Teal
                Color.FromArgb(190, 24, 93),  // Rose/Crimson
            };

            using var fntLabel = new Font("Segoe UI", 8.5f);
            using var brushLab = new SolidBrush(Color.Black);

            for (int i = 0; i < _chartData.Rows.Count; i++)
            {
                int count = Convert.ToInt32(_chartData.Rows[i]["Count"]);
                string displayLoc = _chartData.Rows[i]["Location"]?.ToString() ?? "Unknown";
                displayLoc = displayLoc.Replace(" Region", "");
                if (displayLoc.Length > 10) displayLoc = displayLoc.Substring(0, 8) + "..";

                int barHeight = (int)((double)Math.Min(count, maxCount) / maxCount * chartH);
                int barX = startX + 15 + (barWidth + spacing) * i;
                int barY = startY - barHeight;

                using (var brushBar = new SolidBrush(colors[i % colors.Length]))
                {
                    g.FillRectangle(brushBar, barX, barY, barWidth, barHeight);
                }

                // Label below bar
                var szLoc = g.MeasureString(displayLoc, fntLabel);
                g.DrawString(displayLoc, fntLabel, brushLab, barX + (barWidth - szLoc.Width)/2, startY + 5);
            }
        }

        private void DrawPanelBox(Graphics g, Rectangle bounds)
        {
            bounds.Width -= 6; bounds.Height -= 6;
            using (GraphicsPath shadowPath = GetRoundedRectPath(new Rectangle(bounds.X + 3, bounds.Y + 3, bounds.Width, bounds.Height), 10))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                g.FillPath(shadowBrush, shadowPath);

            using (GraphicsPath path = GetRoundedRectPath(bounds, 10))
            using (SolidBrush bgBrush = new SolidBrush(Color.White))
                g.FillPath(bgBrush, path);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            Rectangle arc = new Rectangle(bounds.X, bounds.Y, d, d);
            GraphicsPath path = new GraphicsPath();
            
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - d;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - d;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Header painting for logo + header gradient
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Professional deep-navy header gradient
            using (LinearGradientBrush grad = new LinearGradientBrush(
                new Point(0, 0), new Point(panelHeader.Width, 0),
                Color.FromArgb(7, 24, 55), Color.FromArgb(12, 40, 90)))
                g.FillRectangle(grad, panelHeader.ClientRectangle);

            // Corporate blue glowing bottom border
            using (LinearGradientBrush borderGrad = new LinearGradientBrush(
                new Point(0, panelHeader.Height - 2), new Point(panelHeader.Width, panelHeader.Height - 2),
                Color.FromArgb(0, 26, 86, 219), Color.FromArgb(220, 26, 86, 219)))
            using (Pen border = new Pen(borderGrad, 2))
                g.DrawLine(border, 0, panelHeader.Height - 1, panelHeader.Width, panelHeader.Height - 1);

            int cx = 45;
            int cy = 37;
            int r = 22;

            // Glowing outer circle — corporate blue
            using (Pen pOuter = new Pen(Color.FromArgb(80, 26, 86, 219), 6f))
                g.DrawEllipse(pOuter, cx - r - 3, cy - r - 3, (r + 3) * 2, (r + 3) * 2);

            // Main circle fill — electric blue gradient
            using (LinearGradientBrush circleBg = new LinearGradientBrush(
                new Point(cx - r, cy - r), new Point(cx + r, cy + r),
                Color.FromArgb(26, 86, 219), Color.FromArgb(14, 61, 167)))
                g.FillEllipse(circleBg, cx - r, cy - r, r * 2, r * 2);

            // Power Tower lines
            using (Pen pLine = new Pen(Color.FromArgb(210, 255, 255, 255), 1.5f))
            {
                g.DrawLine(pLine, cx - 4, cy - 14, cx - 11, cy + 16);
                g.DrawLine(pLine, cx + 4, cy - 14, cx + 11, cy + 16);
                g.DrawLine(pLine, cx - 7, cy - 2, cx + 7, cy - 2);
                g.DrawLine(pLine, cx - 10, cy + 8, cx + 10, cy + 8);
                g.DrawLine(pLine, cx - 7, cy - 2, cx + 10, cy + 8);
                g.DrawLine(pLine, cx + 7, cy - 2, cx - 10, cy + 8);
                g.DrawLine(pLine, cx - 13, cy - 7, cx + 13, cy - 7);
                g.DrawLine(pLine, cx - 17, cy + 1, cx - 7, cy + 1);
                g.DrawLine(pLine, cx + 7, cy + 1, cx + 17, cy + 1);
                g.DrawLine(pLine, cx - 17, cy + 1, cx - 17, cy + 5);
                g.DrawLine(pLine, cx + 17, cy + 1, cx + 17, cy + 5);
            }

            // Lightning Bolt in gold
            Point[] bolt = new Point[] {
                new Point(cx + 10, cy - 14),
                new Point(cx - 1, cy + 1),
                new Point(cx + 6, cy + 1),
                new Point(cx - 2, cy + 18),
                new Point(cx + 14, cy - 1),
                new Point(cx + 5, cy - 1)
            };
            using (SolidBrush bBolt = new SolidBrush(Color.FromArgb(255, 220, 50)))
                g.FillPolygon(bBolt, bolt);
        }

        // Sidebar gradient paint
        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            using (LinearGradientBrush grad = new LinearGradientBrush(
                new Point(0, 0), new Point(0, panelSidebar.Height),
                Color.FromArgb(7, 24, 55), Color.FromArgb(10, 35, 75)))
                g.FillRectangle(grad, panelSidebar.ClientRectangle);

            // Right separator line — subtle blue
            using (Pen sep = new Pen(Color.FromArgb(50, 26, 86, 219), 1))
                g.DrawLine(sep, panelSidebar.Width - 1, 0, panelSidebar.Width - 1, panelSidebar.Height);
        }


        // Navigation logic
        private void btnReport_Click(object? sender, EventArgs e)
        {
            new OutageReportForm(_username).ShowDialog();
            LoadStatistics();
            UpdateNotificationBadge();
        }

        private void btnNotifications_Click(object? sender, EventArgs e)
        {
            using (var form = new NotificationsForm(_username))
            {
                form.ShowDialog();
            }
            UpdateNotificationBadge();
        }

        private void UpdateNotificationBadge()
        {
            if (_role == "Administrator") return; // Admins don't get notifications

            var notifService = new NotificationService();
            int unread = notifService.GetUnreadCount(_username);
            if (unread > 0)
            {
                btnReport.Text = $"🔔 Notifications ({unread})";
                btnReport.ForeColor = Color.Orange; // Yellow badge
            }
            else
            {
                btnReport.Text = "🔔 Notifications";
                btnReport.ForeColor = Color.FromArgb(200, 210, 220); // Normal muted text
            }
        }

        private void btnOutageRecords_Click(object sender, EventArgs e)
        {
            new OutageRecordsForm(_role, _username).ShowDialog();
            LoadStatistics();
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

        private void btnPlannedActivity_Click(object sender, EventArgs e)
        {
            var form = new ManagerPlannedActivityForm();
            form.ShowDialog();
        }

        private void btnDownloadReport_Click(object sender, EventArgs e)
        {
            var service = new SmartPowerOutageSystem.Services.OutageService();
            var reports = service.GetAllReports();
            
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Manager_Report_{DateTime.Now:MMM_yyyy}.txt");
            
            using (var writer = new System.IO.StreamWriter(path))
            {
                writer.WriteLine($"SMART POWER OUTAGE SYSTEM - MONTHLY MANAGER REPORT ({DateTime.Now:MMM yyyy})");
                writer.WriteLine("=====================================================================");
                writer.WriteLine($"Total Reports: {reports.Count}");
                
                int minor = System.Linq.Enumerable.Count(reports, r => r.Severity == "Minor");
                int major = System.Linq.Enumerable.Count(reports, r => r.Severity == "Major");
                writer.WriteLine($"Minor Issues: {minor}");
                writer.WriteLine($"Major Issues: {major}");
                writer.WriteLine($"Unclassified: {reports.Count - minor - major}");
                writer.WriteLine("---------------------------------------------------------------------");
                
                foreach (var report in reports)
                {
                    writer.WriteLine($"Report #{report.ReportID} | Location: {report.Location} | Date: {report.ReportDate:yyyy-MM-dd HH:mm}");
                    writer.WriteLine($"Type: {report.OutageType} | Severity: {report.Severity} | Status: {report.Status}");
                    writer.WriteLine($"Assigned To: {report.AssignedTechnician ?? "None"}");
                    writer.WriteLine($"Description: {report.Description}");
                    writer.WriteLine("---------------------------------------------------------------------");
                }
            }
            
            MessageBox.Show($"Report downloaded to your Desktop:\n{path}", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new OutageStatisticsForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
