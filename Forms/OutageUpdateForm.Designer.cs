using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class OutageUpdateForm
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
            chkIsRestored = new CheckBox();
            dtpRestorationDate = new DateTimePicker();
            lblRestorationDate = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            lblInfo = new Label();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(btnExit);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(550, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UPDATE REPORT STATUS";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(510, 10);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 1;
            btnExit.Text = "✕";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += (s, e) => this.Close();
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(chkIsRestored);
            panelContent.Controls.Add(dtpRestorationDate);
            panelContent.Controls.Add(lblRestorationDate);
            panelContent.Controls.Add(cmbStatus);
            panelContent.Controls.Add(lblStatus);
            panelContent.Controls.Add(lblInfo);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30);
            panelContent.Size = new Size(550, 500);
            panelContent.TabIndex = 1;
            // 
            // chkIsRestored
            // 
            chkIsRestored.AutoSize = true;
            chkIsRestored.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            chkIsRestored.Location = new Point(40, 230);
            chkIsRestored.Name = "chkIsRestored";
            chkIsRestored.Size = new Size(245, 29);
            chkIsRestored.TabIndex = 5;
            chkIsRestored.Text = "Mark as Power Restored";
            chkIsRestored.UseVisualStyleBackColor = true;
            chkIsRestored.CheckedChanged += chkIsRestored_CheckedChanged;
            // 
            // dtpRestorationDate
            // 
            dtpRestorationDate.Enabled = false;
            dtpRestorationDate.Font = new Font("Segoe UI", 11F);
            dtpRestorationDate.Location = new Point(40, 320);
            dtpRestorationDate.Name = "dtpRestorationDate";
            dtpRestorationDate.Size = new Size(470, 32);
            dtpRestorationDate.TabIndex = 4;
            // 
            // lblRestorationDate
            // 
            lblRestorationDate.AutoSize = true;
            lblRestorationDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRestorationDate.Location = new Point(40, 290);
            lblRestorationDate.Name = "lblRestorationDate";
            lblRestorationDate.Size = new Size(144, 23);
            lblRestorationDate.TabIndex = 3;
            lblRestorationDate.Text = "Restoration Date:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 11F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Reported", "Investigating", "Repair in Progress", "Partially Restored", "Restored", "Maintenance" });
            cmbStatus.Location = new Point(40, 180);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(470, 33);
            cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblStatus.Location = new Point(40, 150);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(119, 23);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Current Status";
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.ForeColor = Color.FromArgb(66, 66, 66);
            lblInfo.Location = new Point(40, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(470, 110);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Updating Report for:\r\nLocation: [Location]\r\nType: [Type]";
            lblInfo.UseCompatibleTextRendering = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(37, 99, 235);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Bold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(350, 520);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 45);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F);
            btnCancel.Location = new Point(220, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // OutageUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OutageUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Outage Status";
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
        private Label lblInfo;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblRestorationDate;
        private DateTimePicker dtpRestorationDate;
        private CheckBox chkIsRestored;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnExit;
    }
}
