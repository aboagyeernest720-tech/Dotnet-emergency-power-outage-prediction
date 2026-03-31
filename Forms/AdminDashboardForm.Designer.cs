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
            panelSidebar = new Panel();
            panelMain = new Panel();
            panelFooter = new Panel();
            lblTitle = new Label();
            lblLogo = new Label();
            lblWelcome = new Label();
            btnReport = new Button();
            btnReports = new Button();
            btnLocations = new Button();
            btnUsers = new Button();
            btnStats = new Button();
            btnLogout = new Button();
            lblDashboard = new Label();
            pnlCards = new FlowLayoutPanel();
            pnlRecent = new Panel();
            pnlChart = new Panel();
            lblRecentTitle = new Label();
            lblChartTitle = new Label();
            dgvRecent = new DataGridView();
            lblSystemStatus = new Label();
            lblCopyright = new Label();
            pnlDivider = new Panel();
            
            // Sub-components for cards
            pnlCard1 = new Panel();
            pnlCard2 = new Panel();
            pnlCard3 = new Panel();
            pnlCard4 = new Panel();
            
            lblTotalVal = new Label();
            lblPendingVal = new Label();
            lblResolvedVal = new Label();
            lblTodayVal = new Label();
            
            lblTotalText = new Label();
            lblPendingText = new Label();
            lblResolvedText = new Label();
            lblTodayText = new Label();

            picUser = new Label(); // Simulated icon

            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            pnlCards.SuspendLayout();
            pnlRecent.SuspendLayout();
            pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(picUser);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(580, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Power Outage Prediction System";
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 10F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(900, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(140, 23);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // picUser
            // 
            picUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picUser.Font = new Font("Segoe UI", 18F);
            picUser.ForeColor = Color.White;
            picUser.Location = new Point(850, 25);
            picUser.Name = "picUser";
            picUser.Size = new Size(50, 50);
            picUser.TabIndex = 3;
            picUser.Text = "👤";
            picUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnStats);
            panelSidebar.Controls.Add(btnUsers);
            panelSidebar.Controls.Add(btnLocations);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnReport);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 100);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(15, 30, 15, 30);
            panelSidebar.Size = new Size(250, 570);
            panelSidebar.TabIndex = 1;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(37, 99, 235);
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 10F);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(15, 30);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(220, 55);
            btnReport.TabIndex = 0;
            btnReport.Text = "📝  Report Outage";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.Padding = new Padding(15, 0, 0, 0);
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 10F);
            btnReports.ForeColor = Color.FromArgb(148, 163, 184);
            btnReports.Location = new Point(15, 85);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 55);
            btnReports.TabIndex = 1;
            btnReports.Text = "📄  View Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.Padding = new Padding(15, 0, 0, 0);
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnOutageRecords_Click;
            // 
            // btnLocations
            // 
            btnLocations.Dock = DockStyle.Top;
            btnLocations.FlatAppearance.BorderSize = 0;
            btnLocations.FlatStyle = FlatStyle.Flat;
            btnLocations.Font = new Font("Segoe UI Semibold", 10F);
            btnLocations.ForeColor = Color.FromArgb(148, 163, 184);
            btnLocations.Location = new Point(15, 140);
            btnLocations.Name = "btnLocations";
            btnLocations.Size = new Size(220, 55);
            btnLocations.TabIndex = 2;
            btnLocations.Text = "📍  Manage Locations";
            btnLocations.TextAlign = ContentAlignment.MiddleLeft;
            btnLocations.Padding = new Padding(15, 0, 0, 0);
            btnLocations.UseVisualStyleBackColor = true;
            btnLocations.Click += btnLocationManagement_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 10F);
            btnUsers.ForeColor = Color.FromArgb(148, 163, 184);
            btnUsers.Location = new Point(15, 195);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(220, 55);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "👥  Manage Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.Padding = new Padding(15, 0, 0, 0);
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUserManagement_Click;
            // 
            // btnStats
            // 
            btnStats.Dock = DockStyle.Top;
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Segoe UI Semibold", 10F);
            btnStats.ForeColor = Color.FromArgb(148, 163, 184);
            btnStats.Location = new Point(15, 250);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(220, 55);
            btnStats.TabIndex = 4;
            btnStats.Text = "📊  Statistics";
            btnStats.TextAlign = ContentAlignment.MiddleLeft;
            btnStats.Padding = new Padding(15, 0, 0, 0);
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStatistics_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F);
            btnLogout.ForeColor = Color.FromArgb(239, 68, 68);
            btnLogout.Location = new Point(15, 485);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 55);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(241, 245, 249);
            panelMain.Controls.Add(pnlChart);
            panelMain.Controls.Add(pnlRecent);
            panelMain.Controls.Add(pnlCards);
            panelMain.Controls.Add(pnlDivider);
            panelMain.Controls.Add(lblDashboard);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(850, 570);
            panelMain.TabIndex = 2;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDashboard.ForeColor = Color.FromArgb(15, 23, 42);
            lblDashboard.Location = new Point(30, 20);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(211, 50);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(37, 99, 235);
            pnlDivider.Location = new Point(35, 75);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(150, 4);
            pnlDivider.TabIndex = 1;
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(pnlCard1);
            pnlCards.Controls.Add(pnlCard2);
            pnlCards.Controls.Add(pnlCard3);
            pnlCards.Controls.Add(pnlCard4);
            pnlCards.Location = new Point(30, 100);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(800, 160);
            pnlCards.TabIndex = 2;
            // 
            // pnlCard1 (Total Outages)
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.Controls.Add(lblTotalVal);
            pnlCard1.Controls.Add(lblTotalText);
            pnlCard1.Location = new Point(0, 0);
            pnlCard1.Margin = new Padding(0, 0, 15, 0);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(185, 140);
            pnlCard1.TabIndex = 0;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI Semibold", 10F);
            lblTotalText.ForeColor = Color.FromArgb(100, 116, 139);
            lblTotalText.Location = new Point(15, 15);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(116, 23);
            lblTotalText.TabIndex = 0;
            lblTotalText.Text = "Total Outages";
            // 
            // lblTotalVal
            // 
            lblTotalVal.AutoSize = true;
            lblTotalVal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotalVal.Location = new Point(15, 55);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(81, 62);
            lblTotalVal.TabIndex = 1;
            lblTotalVal.Text = "24";
            // 
            // pnlCard2 (Pending)
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.Controls.Add(lblPendingVal);
            pnlCard2.Controls.Add(lblPendingText);
            pnlCard2.Location = new Point(200, 0);
            pnlCard2.Margin = new Padding(0, 0, 15, 0);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(185, 140);
            pnlCard2.TabIndex = 1;
            // 
            // lblPendingText
            // 
            lblPendingText.AutoSize = true;
            lblPendingText.Font = new Font("Segoe UI Semibold", 10F);
            lblPendingText.ForeColor = Color.FromArgb(100, 116, 139);
            lblPendingText.Location = new Point(15, 15);
            lblPendingText.Name = "lblPendingText";
            lblPendingText.Size = new Size(72, 23);
            lblPendingText.TabIndex = 0;
            lblPendingText.Text = "Pending";
            // 
            // lblPendingVal
            // 
            lblPendingVal.AutoSize = true;
            lblPendingVal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPendingVal.ForeColor = Color.FromArgb(245, 158, 11);
            lblPendingVal.Location = new Point(15, 55);
            lblPendingVal.Name = "lblPendingVal";
            lblPendingVal.Size = new Size(81, 62);
            lblPendingVal.TabIndex = 1;
            lblPendingVal.Text = "08";
            // 
            // pnlCard3 (Resolved)
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.Controls.Add(lblResolvedVal);
            pnlCard3.Controls.Add(lblResolvedText);
            pnlCard3.Location = new Point(400, 0);
            pnlCard3.Margin = new Padding(0, 0, 15, 0);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(185, 140);
            pnlCard3.TabIndex = 2;
            // 
            // lblResolvedText
            // 
            lblResolvedText.AutoSize = true;
            lblResolvedText.Font = new Font("Segoe UI Semibold", 10F);
            lblResolvedText.ForeColor = Color.FromArgb(100, 116, 139);
            lblResolvedText.Location = new Point(15, 15);
            lblResolvedText.Name = "lblResolvedText";
            lblResolvedText.Size = new Size(79, 23);
            lblResolvedText.TabIndex = 0;
            lblResolvedText.Text = "Resolved";
            // 
            // lblResolvedVal
            // 
            lblResolvedVal.AutoSize = true;
            lblResolvedVal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblResolvedVal.ForeColor = Color.FromArgb(16, 185, 129);
            lblResolvedVal.Location = new Point(15, 55);
            lblResolvedVal.Name = "lblResolvedVal";
            lblResolvedVal.Size = new Size(81, 62);
            lblResolvedVal.TabIndex = 1;
            lblResolvedVal.Text = "16";
            // 
            // pnlCard4 (Today)
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.Controls.Add(lblTodayVal);
            pnlCard4.Controls.Add(lblTodayText);
            pnlCard4.Location = new Point(600, 0);
            pnlCard4.Margin = new Padding(0, 0, 15, 0);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(185, 140);
            pnlCard4.TabIndex = 3;
            // 
            // lblTodayText
            // 
            lblTodayText.AutoSize = true;
            lblTodayText.Font = new Font("Segoe UI Semibold", 10F);
            lblTodayText.ForeColor = Color.FromArgb(100, 116, 139);
            lblTodayText.Location = new Point(15, 15);
            lblTodayText.Name = "lblTodayText";
            lblTodayText.Size = new Size(130, 23);
            lblTodayText.TabIndex = 0;
            lblTodayText.Text = "Today's Reports";
            // 
            // lblTodayVal
            // 
            lblTodayVal.AutoSize = true;
            lblTodayVal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTodayVal.ForeColor = Color.FromArgb(99, 102, 241);
            lblTodayVal.Location = new Point(15, 55);
            lblTodayVal.Name = "lblTodayVal";
            lblTodayVal.Size = new Size(81, 62);
            lblTodayVal.TabIndex = 1;
            lblTodayVal.Text = "05";
            // 
            // pnlRecent
            // 
            pnlRecent.BackColor = Color.White;
            pnlRecent.Controls.Add(dgvRecent);
            pnlRecent.Controls.Add(lblRecentTitle);
            pnlRecent.Location = new Point(35, 270);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Padding = new Padding(15);
            pnlRecent.Size = new Size(450, 280);
            pnlRecent.TabIndex = 3;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI Bold", 13F);
            lblRecentTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRecentTitle.Location = new Point(15, 15);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(231, 30);
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
            dgvRecent.Size = new Size(420, 200);
            dgvRecent.TabIndex = 1;
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.White;
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Location = new Point(500, 270);
            pnlChart.Name = "pnlChart";
            pnlChart.Padding = new Padding(15);
            pnlChart.Size = new Size(330, 280);
            pnlChart.TabIndex = 4;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI Bold", 13F);
            lblChartTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblChartTitle.Location = new Point(15, 15);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(174, 30);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Outage Statistics";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(241, 245, 249);
            panelFooter.Controls.Add(lblSystemStatus);
            panelFooter.Controls.Add(lblCopyright);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 670);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1100, 50);
            panelFooter.TabIndex = 3;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F);
            lblCopyright.ForeColor = Color.FromArgb(100, 116, 139);
            lblCopyright.Location = new Point(25, 15);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(244, 20);
            lblCopyright.TabIndex = 0;
            lblCopyright.Text = "© 2026 Power Outage Prediction System";
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSystemStatus.AutoSize = true;
            lblSystemStatus.Font = new Font("Segoe UI Semibold", 9F);
            lblSystemStatus.ForeColor = Color.FromArgb(16, 185, 129);
            lblSystemStatus.Location = new Point(950, 15);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(125, 20);
            lblSystemStatus.TabIndex = 1;
            lblSystemStatus.Text = "● System Online";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 720);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            pnlCards.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            pnlCard4.ResumeLayout(false);
            pnlCard4.PerformLayout();
            pnlRecent.ResumeLayout(false);
            pnlRecent.PerformLayout();
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblLogo;
        private Label lblTitle;
        private Label lblWelcome;
        private Label picUser;
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
        private FlowLayoutPanel pnlCards;
        private Panel pnlCard1;
        private Label lblTotalText;
        private Label lblTotalVal;
        private Panel pnlCard2;
        private Label lblPendingText;
        private Label lblPendingVal;
        private Panel pnlCard3;
        private Label lblResolvedText;
        private Label lblResolvedVal;
        private Panel pnlCard4;
        private Label lblTodayText;
        private Label lblTodayVal;
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
