using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class SignupForm
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
            btnSignup = new Button();
            btnCancel = new Button();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblLocation = new Label();
            cmbLocation = new ComboBox();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 150, 136);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(450, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CREATE ACCOUNT 👤";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnSignup);
            panelContent.Controls.Add(btnCancel);
            panelContent.Controls.Add(lblConfirmPassword);
            panelContent.Controls.Add(txtConfirmPassword);
            panelContent.Controls.Add(lblPassword);
            panelContent.Controls.Add(txtPassword);
            panelContent.Controls.Add(lblLocation);
            panelContent.Controls.Add(cmbLocation);
            panelContent.Controls.Add(lblUsername);
            panelContent.Controls.Add(txtUsername);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(40);
            panelContent.Size = new Size(450, 600);
            panelContent.TabIndex = 1;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(0, 150, 136);
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(50, 480);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(350, 50);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "R E G I S T E R";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Gray;
            btnCancel.Location = new Point(175, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(50, 290);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(149, 23);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(50, 320);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(350, 34);
            txtConfirmPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(50, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(50, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(350, 34);
            txtPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(50, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(153, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Choose Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(50, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(350, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(50, 375);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(130, 23);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Select Location";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Font = new Font("Segoe UI", 12F);
            cmbLocation.Location = new Point(50, 405);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(350, 36);
            cmbLocation.TabIndex = 4;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 700);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Signup";
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
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSignup;
        private Button btnCancel;
        private Label lblLocation;
        private ComboBox cmbLocation;
    }
}
