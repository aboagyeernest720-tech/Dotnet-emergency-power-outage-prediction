using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class UserIdentificationForm
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
            lblPrompt = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPrompt.Location = new Point(30, 20);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(340, 50);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Please identify yourself to proceed with reporting.";
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 100);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter full name";
            txtName.Size = new Size(340, 27);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Enter phone number";
            txtPhone.Size = new Size(340, 27);
            txtPhone.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(63, 81, 181);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(180, 210);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(90, 35);
            btnOk.TabIndex = 3;
            btnOk.Text = "CONTINUE";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(280, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(30, 137);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // UserIdentificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 280);
            ControlBox = false;
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblPrompt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UserIdentificationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Identify Yourself";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblPrompt;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnOk;
        private Button btnCancel;
        private Label lblName;
        private Label lblPhone;
    }
}
