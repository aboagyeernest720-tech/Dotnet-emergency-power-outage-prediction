using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class UserDashboardForm
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
            btnReport = new Button();
            btnNotifications = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            panelTop = new Panel();
            btnExit = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            pnlStatusCard = new Panel();
            lblStatus = new Label();
            lblStatusTitle = new Label();
            lblLocation = new Label();
            pnlNotif = new Panel();
            lblNotifTitle = new Label();
            lblNotifText = new Label();
            lblNotifDate = new Label();
            btnRefresh = new Button();
            panelSidebar.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            pnlStatusCard.SuspendLayout();
            pnlNotif.SuspendLayout();
            SuspendLayout();
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59); // Dark blue sidebar
            panelSidebar.Controls.Add(btnSettings);
            panelSidebar.Controls.Add(btnNotifications);
            panelSidebar.Controls.Add(btnReport);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(260, 720);
            panelSidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(17, 33, 51);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(260, 100);
            panelLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 100);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "OUTAGE PREDICTION\r\nUSER PORTAL";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(37, 99, 235);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 100);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(260, 55);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "  🏠   User Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI Semibold", 10F);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(0, 150);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(250, 50);
            btnReport.TabIndex = 3;
            btnReport.Text = "➕ Report Outage";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.Padding = new Padding(20, 0, 0, 0);
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Dock = DockStyle.Top;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Segoe UI Semibold", 10F);
            btnNotifications.ForeColor = Color.White;
            btnNotifications.Location = new Point(0, 200);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(250, 50);
            btnNotifications.TabIndex = 4;
            btnNotifications.Text = "🔔 Notifications";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Padding = new Padding(20, 0, 0, 0);
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 250);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(250, 50);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "⚙️ Profile Settings";
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
            btnLogout.ForeColor = Color.FromArgb(236, 240, 241);
            btnLogout.Location = new Point(0, 670);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(17, 33, 51);
            panelTop.Controls.Add(btnExit);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(260, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(764, 100);
            panelTop.TabIndex = 1;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Power Outage Prediction System";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(710, 25);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "✕";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.Font = new Font("Segoe UI Semibold", 10F);
            lblWelcome.ForeColor = Color.FromArgb(148, 163, 184);
            lblWelcome.Location = new Point(450, 35);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(250, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, User";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 247, 250);
            panelMain.Controls.Add(btnRefresh);
            panelMain.Controls.Add(pnlNotif);
            panelMain.Controls.Add(pnlStatusCard);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(774, 640);
            panelMain.TabIndex = 2;
            // 
            // pnlStatusCard
            // 
            pnlStatusCard.BackColor = Color.White;
            pnlStatusCard.Controls.Add(lblLocation);
            pnlStatusCard.Controls.Add(lblStatus);
            pnlStatusCard.Controls.Add(lblStatusTitle);
            pnlStatusCard.Dock = DockStyle.Top;
            pnlStatusCard.Location = new Point(30, 30);
            pnlStatusCard.Name = "pnlStatusCard";
            pnlStatusCard.Size = new Size(714, 180);
            pnlStatusCard.TabIndex = 0;
            
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblStatusTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatusTitle.Location = new Point(30, 30);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(130, 28);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Current Status";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(16, 185, 129); // Vibrant Green
            lblStatus.Location = new Point(30, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(650, 70);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "POWER ONLINE";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 10.5F);
            lblLocation.ForeColor = Color.FromArgb(100, 116, 139);
            lblLocation.Location = new Point(30, 140);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(141, 23);
            lblLocation.TabIndex = 2;
            lblLocation.Text = "📍 Home Sector";
            // 
            // pnlNotif
            // 
            pnlNotif.BackColor = Color.FromArgb(255, 243, 224);
            pnlNotif.Controls.Add(lblNotifDate);
            pnlNotif.Controls.Add(lblNotifText);
            pnlNotif.Controls.Add(lblNotifTitle);
            pnlNotif.Location = new Point(30, 230);
            pnlNotif.Name = "pnlNotif";
            pnlNotif.Size = new Size(714, 120);
            pnlNotif.TabIndex = 1;
            pnlNotif.Visible = false;
            // 
            // lblNotifTitle
            // 
            lblNotifTitle.AutoSize = true;
            lblNotifTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNotifTitle.ForeColor = Color.FromArgb(230, 81, 0);
            lblNotifTitle.Location = new Point(20, 15);
            lblNotifTitle.Name = "lblNotifTitle";
            lblNotifTitle.Size = new Size(207, 28);
            lblNotifTitle.TabIndex = 0;
            lblNotifTitle.Text = "Maintenance Alert";
            // 
            // lblNotifText
            // 
            lblNotifText.Font = new Font("Segoe UI", 10F);
            lblNotifText.Location = new Point(20, 45);
            lblNotifText.Name = "lblNotifText";
            lblNotifText.Size = new Size(670, 30);
            lblNotifText.TabIndex = 1;
            lblNotifText.Text = "Planned maintenance reported for your area.";
            // 
            // lblNotifDate
            // 
            lblNotifDate.AutoSize = true;
            lblNotifDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNotifDate.ForeColor = Color.FromArgb(216, 67, 21);
            lblNotifDate.Location = new Point(20, 80);
            lblNotifDate.Name = "lblNotifDate";
            lblNotifDate.Size = new Size(220, 23);
            lblNotifDate.TabIndex = 2;
            lblNotifDate.Text = "Oct 25, 14:00 - 16:00";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(37, 99, 235);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.5F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(30, 370);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 45);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh Tracker";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboardForm";
            panelSidebar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            pnlStatusCard.ResumeLayout(false);
            pnlStatusCard.PerformLayout();
            pnlNotif.ResumeLayout(false);
            pnlNotif.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelLogo;
        private Label lblLogo;
        private Button btnDashboard;
        private Button btnReport;
        private Button btnNotifications;
        private Button btnSettings;
        private Button btnLogout;
        private Panel panelTop;
        private Button btnExit;
        private Label lblWelcome;
        private Label lblTitle;
        private Panel panelMain;
        private Panel pnlStatusCard;
        private Label lblStatus;
        private Label lblStatusTitle;
        private Label lblLocation;
        private Panel pnlNotif;
        private Label lblNotifTitle;
        private Label lblNotifText;
        private Label lblNotifDate;
        private Button btnRefresh;
    }
}
