using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class NotificationsForm
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
            btnMarkRead = new Button();
            dgvNotifs = new DataGridView();
            btnClose = new Button();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotifs).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NOTIFICATIONS";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnMarkRead);
            panelContent.Controls.Add(dgvNotifs);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(800, 500);
            panelContent.TabIndex = 1;
            // 
            // btnMarkRead
            // 
            btnMarkRead.BackColor = Color.FromArgb(37, 99, 235);
            btnMarkRead.FlatStyle = FlatStyle.Flat;
            btnMarkRead.Font = new Font("Segoe UI Semibold", 10F);
            btnMarkRead.ForeColor = Color.White;
            btnMarkRead.Location = new Point(20, 440);
            btnMarkRead.Name = "btnMarkRead";
            btnMarkRead.Size = new Size(160, 40);
            btnMarkRead.TabIndex = 1;
            btnMarkRead.Text = "Mark as Read";
            btnMarkRead.UseVisualStyleBackColor = false;
            btnMarkRead.Click += btnMarkRead_Click;
            // 
            // dgvNotifs
            // 
            dgvNotifs.AllowUserToAddRows = false;
            dgvNotifs.AllowUserToDeleteRows = false;
            dgvNotifs.BackgroundColor = Color.White;
            dgvNotifs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifs.Location = new Point(20, 20);
            dgvNotifs.MultiSelect = false;
            dgvNotifs.Name = "dgvNotifs";
            dgvNotifs.ReadOnly = true;
            dgvNotifs.RowHeadersVisible = false;
            dgvNotifs.RowTemplate.Height = 40;
            dgvNotifs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotifs.Size = new Size(760, 400);
            dgvNotifs.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(760, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.Click += btnClose_Click;
            // 
            // NotificationsForm (In Main Controls)
            // 
            panelHeader.Controls.Add(btnClose);
            // 
            // NotificationsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationsForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotifs).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private DataGridView dgvNotifs;
        private Button btnMarkRead;
        private Button btnClose;
    }
}
