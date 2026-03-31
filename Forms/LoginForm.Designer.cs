using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class LoginForm
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            panelContent = new Panel();
            btnSignup = new Button();
            btnExit = new Button();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 33, 51); // Premium Deep Blue
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 160);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Power Outage Prediction System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitle.Location = new Point(115, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(248, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Power Intelligence System";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnSignup);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(btnLogin);
            panelContent.Controls.Add(lblPassword);
            panelContent.Controls.Add(txtPassword);
            panelContent.Controls.Add(lblUsername);
            panelContent.Controls.Add(txtUsername);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 150);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40);
            panelContent.Size = new Size(500, 480);
            panelContent.TabIndex = 1;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Transparent;
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Semibold", 10F);
            btnSignup.ForeColor = Color.FromArgb(71, 85, 105);
            btnSignup.Location = new Point(80, 290);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(340, 45);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "Create New Account";
            btnSignup.UseVisualStyleBackColor = false;
            btnExit.BackColor = Color.FromArgb(238, 238, 238);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExit.Location = new Point(80, 360);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(340, 45);
            btnExit.TabIndex = 6;
            btnExit.Text = "E X I T";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 99, 235); // Modern Blue
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(66, 66, 66);
            lblPassword.Location = new Point(80, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(80, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(340, 36);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(66, 66, 66);
            lblUsername.Location = new Point(80, 35);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(98, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(80, 65);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(340, 36);
            txtUsername.TabIndex = 1;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 630);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Power Outage Prediction System";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelContent;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Button btnSignup;
    }
}
