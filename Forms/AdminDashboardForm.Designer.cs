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
            panelSidebar = new Panel();
            panelLogo = new Panel();
            lblLogo = new Label();
            btnDashboard = new Button();
            btnUsers = new Button();
            btnLocations = new Button();
            btnRecords = new Button();
            btnPlanned = new Button();
            btnStats = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            panelTop = new Panel();
            lblWelcome = new Label();
            lblTitle = new Label();
            btnExit = new Button();
            panelMain = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlTotalUsers = new Panel();
            lblTotalUsers = new Label();
            lblUserTitle = new Label();
            pnlTotalReports = new Panel();
            lblTotalReports = new Label();
            lblReportTitle = new Label();
            pnlActiveOutages = new Panel();
            lblActiveOutages = new Label();
            lblActiveTitle = new Label();
            pnlPredictCard = new Panel();
            lblPrediction = new Label();
            lblPredictTitle = new Label();
            btnRefresh = new Button();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlTotalUsers.SuspendLayout();
            pnlTotalReports.SuspendLayout();
            pnlActiveOutages.SuspendLayout();
            pnlPredictCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(26, 37, 47);
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnStats);
            panelSidebar.Controls.Add(btnPlanned);
            panelSidebar.Controls.Add(btnRecords);
            panelSidebar.Controls.Add(btnLocations);
            panelSidebar.Controls.Add(btnUsers);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 720);
            panelSidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(26, 37, 47);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(52, 152, 219);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 100);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SMART POWER\r\nADMIN HUB";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(44, 62, 80);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(250, 50);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 10F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(0, 150);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(250, 50);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "👥 User Management";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.Padding = new Padding(20, 0, 0, 0);
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUserManagement_Click;
            // 
            // btnLocations
            // 
            btnLocations.Dock = DockStyle.Top;
            btnLocations.FlatAppearance.BorderSize = 0;
            btnLocations.FlatStyle = FlatStyle.Flat;
            btnLocations.Font = new Font("Segoe UI Semibold", 10F);
            btnLocations.ForeColor = Color.White;
            btnLocations.Location = new Point(0, 200);
            btnLocations.Name = "btnLocations";
            btnLocations.Size = new Size(250, 50);
            btnLocations.TabIndex = 4;
            btnLocations.Text = "📍 Locations";
            btnLocations.TextAlign = ContentAlignment.MiddleLeft;
            btnLocations.Padding = new Padding(20, 0, 0, 0);
            btnLocations.UseVisualStyleBackColor = true;
            btnLocations.Click += btnLocationManagement_Click;
            // 
            // btnRecords
            // 
            btnRecords.Dock = DockStyle.Top;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Segoe UI Semibold", 10F);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(0, 250);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(250, 50);
            btnRecords.TabIndex = 5;
            btnRecords.Text = "📜 Outage Records";
            btnRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnRecords.Padding = new Padding(20, 0, 0, 0);
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnOutageRecords_Click;
            // 
            // btnPlanned
            // 
            btnPlanned.Dock = DockStyle.Top;
            btnPlanned.FlatAppearance.BorderSize = 0;
            btnPlanned.FlatStyle = FlatStyle.Flat;
            btnPlanned.Font = new Font("Segoe UI Semibold", 10F);
            btnPlanned.ForeColor = Color.White;
            btnPlanned.Location = new Point(0, 300);
            btnPlanned.Name = "btnPlanned";
            btnPlanned.Size = new Size(250, 50);
            btnPlanned.TabIndex = 6;
            btnPlanned.Text = "🔔 Planned Ops";
            btnPlanned.TextAlign = ContentAlignment.MiddleLeft;
            btnPlanned.Padding = new Padding(20, 0, 0, 0);
            btnPlanned.UseVisualStyleBackColor = true;
            btnPlanned.Click += btnPlannedOperations_Click;
            // 
            // btnStats
            // 
            btnStats.Dock = DockStyle.Top;
            btnStats.FlatAppearance.BorderSize = 0;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Font = new Font("Segoe UI Semibold", 10F);
            btnStats.ForeColor = Color.White;
            btnStats.Location = new Point(0, 350);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(250, 50);
            btnStats.TabIndex = 7;
            btnStats.Text = "📊 Analysis";
            btnStats.TextAlign = ContentAlignment.MiddleLeft;
            btnStats.Padding = new Padding(20, 0, 0, 0);
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStatistics_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 400);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(250, 50);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "⚙️ Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.Padding = new Padding(20, 0, 0, 0);
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 10F);
            btnLogout.ForeColor = Color.FromArgb(231, 76, 60);
            btnLogout.Location = new Point(0, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(btnExit);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(250, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(774, 80);
            panelTop.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.Font = new Font("Segoe UI Semibold", 10F);
            lblWelcome.ForeColor = Color.FromArgb(127, 140, 141);
            lblWelcome.Location = new Point(400, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(250, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADMIN PANEL";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(189, 195, 199);
            btnExit.Location = new Point(720, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "×";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(pnlPredictCard);
            panelMain.Controls.Add(flowLayoutPanel1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(774, 640);
            panelMain.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pnlTotalUsers);
            flowLayoutPanel1.Controls.Add(pnlTotalReports);
            flowLayoutPanel1.Controls.Add(pnlActiveOutages);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(20, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(734, 180);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlTotalUsers
            // 
            pnlTotalUsers.BackColor = Color.White;
            pnlTotalUsers.Controls.Add(lblTotalUsers);
            pnlTotalUsers.Controls.Add(lblUserTitle);
            pnlTotalUsers.Location = new Point(10, 10);
            pnlTotalUsers.Margin = new Padding(10);
            pnlTotalUsers.Name = "pnlTotalUsers";
            pnlTotalUsers.Size = new Size(220, 140);
            pnlTotalUsers.TabIndex = 0;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = true;
            lblUserTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblUserTitle.ForeColor = Color.FromArgb(149, 165, 166);
            lblUserTitle.Location = new Point(15, 15);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(93, 23);
            lblUserTitle.TabIndex = 0;
            lblUserTitle.Text = "Total Users";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalUsers.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalUsers.Location = new Point(15, 55);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(190, 60);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "0";
            lblTotalUsers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTotalReports
            // 
            pnlTotalReports.BackColor = Color.White;
            pnlTotalReports.Controls.Add(lblTotalReports);
            pnlTotalReports.Controls.Add(lblReportTitle);
            pnlTotalReports.Location = new Point(250, 10);
            pnlTotalReports.Margin = new Padding(10);
            pnlTotalReports.Name = "pnlTotalReports";
            pnlTotalReports.Size = new Size(220, 140);
            pnlTotalReports.TabIndex = 1;
            // 
            // lblReportTitle
            // 
            lblReportTitle.AutoSize = true;
            lblReportTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblReportTitle.ForeColor = Color.FromArgb(149, 165, 166);
            lblReportTitle.Location = new Point(15, 15);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(110, 23);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "Total Reports";
            // 
            // lblTotalReports
            // 
            lblTotalReports.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalReports.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotalReports.Location = new Point(15, 55);
            lblTotalReports.Name = "lblTotalReports";
            lblTotalReports.Size = new Size(190, 60);
            lblTotalReports.TabIndex = 1;
            lblTotalReports.Text = "0";
            lblTotalReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlActiveOutages
            // 
            pnlActiveOutages.BackColor = Color.White;
            pnlActiveOutages.Controls.Add(lblActiveOutages);
            pnlActiveOutages.Controls.Add(lblActiveTitle);
            pnlActiveOutages.Location = new Point(490, 10);
            pnlActiveOutages.Margin = new Padding(10);
            pnlActiveOutages.Name = "pnlActiveOutages";
            pnlActiveOutages.Size = new Size(220, 140);
            pnlActiveOutages.TabIndex = 2;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblActiveTitle.ForeColor = Color.FromArgb(149, 165, 166);
            lblActiveTitle.Location = new Point(15, 15);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(125, 23);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "Active Outages";
            // 
            // lblActiveOutages
            // 
            lblActiveOutages.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblActiveOutages.ForeColor = Color.FromArgb(231, 76, 60);
            lblActiveOutages.Location = new Point(15, 55);
            lblActiveOutages.Name = "lblActiveOutages";
            lblActiveOutages.Size = new Size(190, 60);
            lblActiveOutages.TabIndex = 1;
            lblActiveOutages.Text = "0";
            lblActiveOutages.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPredictCard
            // 
            pnlPredictCard.BackColor = Color.FromArgb(44, 62, 80);
            pnlPredictCard.Controls.Add(lblPrediction);
            pnlPredictCard.Controls.Add(lblPredictTitle);
            pnlPredictCard.Location = new Point(30, 220);
            pnlPredictCard.Name = "pnlPredictCard";
            pnlPredictCard.Size = new Size(690, 150);
            pnlPredictCard.TabIndex = 1;
            // 
            // lblPredictTitle
            // 
            lblPredictTitle.AutoSize = true;
            lblPredictTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblPredictTitle.ForeColor = Color.FromArgb(52, 152, 219);
            lblPredictTitle.Location = new Point(20, 20);
            lblPredictTitle.Name = "lblPredictTitle";
            lblPredictTitle.Size = new Size(260, 28);
            lblPredictTitle.TabIndex = 0;
            lblPredictTitle.Text = "Smart Predictive Analysis 🔍";
            // 
            // lblPrediction
            // 
            lblPrediction.Font = new Font("Segoe UI Semibold", 14F);
            lblPrediction.ForeColor = Color.White;
            lblPrediction.Location = new Point(20, 65);
            lblPrediction.Name = "lblPrediction";
            lblPrediction.Size = new Size(650, 70);
            lblPrediction.TabIndex = 1;
            lblPrediction.Text = "Analyzing patterns...";
            lblPrediction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(189, 195, 199);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F);
            btnRefresh.Location = new Point(30, 390);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardForm";
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnlTotalUsers.ResumeLayout(false);
            pnlTotalUsers.PerformLayout();
            pnlTotalReports.ResumeLayout(false);
            pnlTotalReports.PerformLayout();
            pnlActiveOutages.ResumeLayout(false);
            pnlActiveOutages.PerformLayout();
            pnlPredictCard.ResumeLayout(false);
            pnlPredictCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelLogo;
        private Label lblLogo;
        private Button btnDashboard;
        private Button btnUsers;
        private Button btnLocations;
        private Button btnRecords;
        private Button btnPlanned;
        private Button btnStats;
        private Button btnSettings;
        private Button btnLogout;
        private Panel panelTop;
        private Label lblTitle;
        private Label lblWelcome;
        private Button btnExit;
        private Panel panelMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlTotalUsers;
        private Label lblUserTitle;
        private Label lblTotalUsers;
        private Panel pnlTotalReports;
        private Label lblTotalReports;
        private Label lblReportTitle;
        private Panel pnlActiveOutages;
        private Label lblActiveOutages;
        private Label lblActiveTitle;
        private Panel pnlPredictCard;
        private Label lblPredictTitle;
        private Label lblPrediction;
        private Button btnRefresh;
    }
}
