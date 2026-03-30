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
            btnGuestLogin = new Button();
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
            panelHeader.BackColor = Color.FromArgb(63, 81, 181);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 150);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(197, 202, 233);
            lblSubtitle.Location = new Point(125, 85);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(241, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Prediction & Monitoring System";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(35, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(423, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "POWER MONITORING";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnSignup);
            panelContent.Controls.Add(btnGuestLogin);
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
            btnSignup.BackColor = Color.FromArgb(238, 238, 238);
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSignup.Location = new Point(80, 270);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(340, 45);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "S I G N  U P";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnGuestLogin
            // 
            btnGuestLogin.FlatAppearance.BorderSize = 0;
            btnGuestLogin.FlatStyle = FlatStyle.Flat;
            btnGuestLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnGuestLogin.ForeColor = Color.FromArgb(63, 81, 181);
            btnGuestLogin.Location = new Point(125, 420);
            btnGuestLogin.Name = "btnGuestLogin";
            btnGuestLogin.Size = new Size(250, 30);
            btnGuestLogin.TabIndex = 7;
            btnGuestLogin.Text = "Login as Regular User (Guest)";
            btnGuestLogin.UseVisualStyleBackColor = true;
            btnGuestLogin.Click += btnGuestLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(238, 238, 238);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExit.Location = new Point(80, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(340, 45);
            btnExit.TabIndex = 6;
            btnExit.Text = "E X I T";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(63, 81, 181);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "L O G I N";
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
            Text = "Login - Smart Power Monitoring";
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
        private Button btnGuestLogin;
        private Button btnSignup;
    }
}
