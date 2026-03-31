using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblWelcome = new Label();
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnStats = new Button();
            btnUsers = new Button();
            btnLocations = new Button();
            btnReports = new Button();
            btnReport = new Button();
            panelMain = new Panel();
            pnlCards = new Panel();
            pnlChart = new Panel();
            lblChartTitle = new Label();
            pnlRecent = new Panel();
            lblRecentTitle = new Label();
            dgvRecent = new DataGridView();
            lblDashboard = new Label();
            pnlDivider = new Panel();
            panelFooter = new Panel();
            lblSystemStatus = new Label();
            lblCopyright = new Label();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            pnlChart.SuspendLayout();
            pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(7, 24, 55);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1150, 75);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(90, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(580, 35);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "SMART POWER OUTAGE MONITORING SYSTEM";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.FromArgb(147, 197, 253);
            lblWelcome.Location = new Point(880, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(160, 25);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "👤 Welcome, Admin";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(7, 24, 55);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnStats);
            panelSidebar.Controls.Add(btnUsers);
            panelSidebar.Controls.Add(btnLocations);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnReport);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 75);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(12, 20, 12, 20);
            panelSidebar.Size = new Size(220, 675);
            panelSidebar.TabIndex = 1;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(26, 86, 219);
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 9F);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(12, 20);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(14, 0, 0, 0);
            btnReport.Size = new Size(196, 58);
            btnReport.TabIndex = 0;
            btnReport.Text = "📄  Report Outage";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 9F);
            btnReports.ForeColor = Color.FromArgb(148, 163, 184);
            btnReports.Location = new Point(12, 78);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(14, 0, 0, 0);
            btnReports.Size = new Size(196, 55);
            btnReports.TabIndex = 1;
            btnReports.Text = "📋  View Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnOutageRecords_Click;
            // 
            // btnLocations
            // 
            btnLocations.Dock = DockStyle.Top;
            btnLocations.FlatAppearance.BorderSize = 0;
            btnLocations.FlatStyle = FlatStyle.Flat;
            btnLocations.Font = new Font("Segoe UI Semibold", 9F);
            btnLocations.ForeColor = Color.FromArgb(148, 163, 184);
            btnLocations.Location = new Point(12, 133);
            btnLocations.Name = "btnLocations";
            btnLocations.Padding = new Padding(14, 0, 0, 0);
            btnLocations.Size = new Size(196, 55);
            btnLocations.TabIndex = 2;
            btnLocations.Text = "📍  Manage Locations";
            btnLocations.TextAlign = ContentAlignment.MiddleLeft;
            btnLocations.UseVisualStyleBackColor = true;
            btnLocations.Click += btnLocationManagement_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 9F);
            btnUsers.ForeColor = Color.FromArgb(148, 163, 184);
            btnUsers.Location = new Point(12, 188);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(14, 0, 0, 0);
            btnUsers.Size = new Size(196, 55);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "👥  Manage Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUserManagement_Click;
            // 
            // btnStats
            // 
            btnStats.Dock = DockStyle.Top;
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Segoe UI Semibold", 9F);
            btnStats.ForeColor = Color.FromArgb(148, 163, 184);
            btnStats.Location = new Point(12, 243);
            btnStats.Name = "btnStats";
            btnStats.Padding = new Padding(14, 0, 0, 0);
            btnStats.Size = new Size(196, 55);
            btnStats.TabIndex = 4;
            btnStats.Text = "📈  Statistics";
            btnStats.TextAlign = ContentAlignment.MiddleLeft;
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStatistics_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F);
            btnLogout.ForeColor = Color.FromArgb(252, 165, 165);
            btnLogout.Location = new Point(12, 595);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Size = new Size(196, 55);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(240, 245, 250);
            panelMain.Controls.Add(pnlChart);
            panelMain.Controls.Add(pnlRecent);
            panelMain.Controls.Add(pnlCards);
            panelMain.Controls.Add(pnlDivider);
            panelMain.Controls.Add(lblDashboard);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 75);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(930, 675);
            panelMain.TabIndex = 2;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(15, 23, 42);
            lblDashboard.Location = new Point(28, 14);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(225, 50);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(26, 86, 219);
            pnlDivider.Location = new Point(33, 72);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(115, 4);
            pnlDivider.TabIndex = 1;
            // 
            // pnlCards
            // 
            pnlCards.BackColor = Color.Transparent;
            pnlCards.Location = new Point(20, 88);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(892, 135);
            pnlCards.TabIndex = 2;
            pnlCards.Paint += pnlCards_Paint;
            // 
            // pnlRecent
            // 
            pnlRecent.Controls.Add(lblRecentTitle);
            pnlRecent.Controls.Add(dgvRecent);
            pnlRecent.Location = new Point(25, 260);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Size = new Size(500, 340);
            pnlRecent.TabIndex = 3;
            pnlRecent.Paint += pnlRecent_Paint;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.BackColor = Color.White;
            lblRecentTitle.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRecentTitle.Location = new Point(18, 16);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(254, 30);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "Recent Outage Reports";
            // 
            // dgvRecent
            // 
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(15, 60);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.Size = new Size(470, 265);
            dgvRecent.TabIndex = 1;
            // 
            // pnlChart
            // 
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Location = new Point(540, 260);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(330, 340);
            pnlChart.TabIndex = 4;
            pnlChart.Paint += pnlChart_Paint;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.BackColor = Color.White;
            lblChartTitle.Font = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblChartTitle.Location = new Point(18, 16);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(187, 30);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Outage Statistics";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(7, 24, 55);
            panelFooter.Controls.Add(lblSystemStatus);
            panelFooter.Controls.Add(lblCopyright);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 750);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1150, 40);
            panelFooter.TabIndex = 3;
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSystemStatus.AutoSize = true;
            lblSystemStatus.Font = new Font("Segoe UI Semibold", 9F);
            lblSystemStatus.ForeColor = Color.FromArgb(52, 211, 153);
            lblSystemStatus.Location = new Point(1005, 11);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(125, 20);
            lblSystemStatus.TabIndex = 1;
            lblSystemStatus.Text = "● System Online";
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F);
            lblCopyright.ForeColor = Color.FromArgb(100, 116, 139);
            lblCopyright.Location = new Point(15, 11);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(244, 20);
            lblCopyright.TabIndex = 0;
            lblCopyright.Text = "© 2025 Power Outage Monitoring System";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 795);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Power Outage Monitoring System";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
            pnlRecent.ResumeLayout(false);
            pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblWelcome;
        private Panel panelSidebar;
        private Button btnReport;
        private Button btnReports;
        private Button btnLocations;
        private Button btnUsers;
        private Button btnStats;
        private Button btnLogout;
        private Panel panelMain;
        private Label lblDashboard;
        private Panel pnlDivider;
        private Panel pnlCards;
        private Panel pnlRecent;
        private Label lblRecentTitle;
        private DataGridView dgvRecent;
        private Panel pnlChart;
        private Label lblChartTitle;
        private Panel panelFooter;
        private Label lblCopyright;
        private Label lblSystemStatus;
    }
}
