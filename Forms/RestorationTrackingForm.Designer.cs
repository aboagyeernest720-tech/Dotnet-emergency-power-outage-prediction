using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class RestorationTrackingForm
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
            lblSubtitle = new Label();
            btnBack = new Button();
            panelContent = new Panel();
            dgvRestoration = new DataGridView();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestoration).BeginInit();
            SuspendLayout();
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 100);
            panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(950, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 2;
            btnBack.Text = "← DASHBOARD";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(545, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "⚡ RESTORATION METRICS";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(178, 223, 219);
            lblSubtitle.Location = new Point(35, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(410, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Detailed history of resolved outages and restoration efficiency.";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvRestoration);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 100);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(1100, 550);
            panelContent.TabIndex = 1;
            dgvRestoration.AllowUserToAddRows = false;
            dgvRestoration.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestoration.BackgroundColor = Color.White;
            dgvRestoration.BorderStyle = BorderStyle.None;
            dgvRestoration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRestoration.Dock = DockStyle.Fill;
            dgvRestoration.Location = new Point(25, 25);
            dgvRestoration.Name = "dgvRestoration";
            dgvRestoration.ReadOnly = true;
            dgvRestoration.RowHeadersVisible = false;
            dgvRestoration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRestoration.Size = new Size(1050, 500);
            dgvRestoration.TabIndex = 0;
            dgvRestoration.EnableHeadersVisualStyles = false;
            dgvRestoration.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            dgvRestoration.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRestoration.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            // 
            // RestorationTrackingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 650);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "RestorationTrackingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Efficiency Tracker";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRestoration).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel panelContent;
        private DataGridView dgvRestoration;
        private Button btnBack;
    }
}
