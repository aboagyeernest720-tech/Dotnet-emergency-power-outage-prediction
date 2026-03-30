using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class AboutSystemForm
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
            lblTitle = new Label();
            lblVersion = new Label();
            lblDescription = new Label();
            lblGroup = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(63, 81, 181);
            lblTitle.Location = new Point(0, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Smart Power Outage System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(0, 75);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(500, 25);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version 1.0.0 (BETA)";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(40, 120);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(420, 120);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "This system is designed to provide efficient monitoring and prediction of power outages. It allows quick reporting, tracking, and management of electrical failures across multiple locations to improve response times for maintenance teams.";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGroup
            // 
            lblGroup.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGroup.ForeColor = Color.FromArgb(76, 175, 80);
            lblGroup.Location = new Point(0, 260);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(500, 30);
            lblGroup.TabIndex = 3;
            lblGroup.Text = "Developed by: GROUP THREE";
            lblGroup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(240, 240, 240);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(190, 320);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 35);
            btnOk.TabIndex = 4;
            btnOk.Text = "Close";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // AboutSystemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 400);
            Controls.Add(btnOk);
            Controls.Add(lblGroup);
            Controls.Add(lblDescription);
            Controls.Add(lblVersion);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About System";
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitle;
        private Label lblVersion;
        private Label lblDescription;
        private Label lblGroup;
        private Button btnOk;
    }
}
