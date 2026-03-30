using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class SettingsForm
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
            panelContent = new Panel();
            btnSave = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            btnCancel = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(63, 81, 181);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ACCOUNT SETTINGS";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnCancel);
            panelContent.Controls.Add(btnSave);
            panelContent.Controls.Add(txtConfirmPassword);
            panelContent.Controls.Add(lblConfirmPassword);
            panelContent.Controls.Add(txtNewPassword);
            panelContent.Controls.Add(lblNewPassword);
            panelContent.Controls.Add(txtUsername);
            panelContent.Controls.Add(lblUsername);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40);
            panelContent.Size = new Size(500, 450);
            panelContent.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(63, 81, 181);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Bold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(420, 50);
            btnSave.TabIndex = 6;
            btnSave.Text = "UPDATE PASSWORD";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(40, 250);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Repeat new password";
            txtConfirmPassword.Size = new Size(420, 34);
            txtConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(40, 220);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(149, 23);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(40, 160);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "Enter new password";
            txtNewPassword.Size = new Size(420, 34);
            txtNewPassword.TabIndex = 3;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNewPassword.Location = new Point(40, 130);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(122, 23);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(40, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = false;
            txtUsername.Size = new Size(420, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(40, 40);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(40, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(420, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Back to Dashboard";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 550);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Settings";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}
