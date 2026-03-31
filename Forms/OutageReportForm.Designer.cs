using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class OutageReportForm
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            lblLocation = new Label();
            cmbLocation = new ComboBox();
            lblOutageType = new Label();
            cmbOutageType = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblReportedBy = new Label();
            txtReportedBy = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(650, 100);
            panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(500, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "← DASHBOARD";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "REPORT AN OUTAGE";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLocation.Location = new Point(40, 110);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(79, 23);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location:";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Font = new Font("Segoe UI", 11F);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(40, 140);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(570, 33);
            cmbLocation.TabIndex = 2;
            // 
            // lblOutageType
            // 
            lblOutageType.AutoSize = true;
            lblOutageType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOutageType.Location = new Point(40, 190);
            lblOutageType.Name = "lblOutageType";
            lblOutageType.Size = new Size(111, 23);
            lblOutageType.TabIndex = 3;
            lblOutageType.Text = "Outage Type:";
            // 
            // cmbOutageType
            // 
            cmbOutageType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOutageType.Font = new Font("Segoe UI", 11F);
            cmbOutageType.FormattingEnabled = true;
            cmbOutageType.Items.AddRange(new object[] { "Planned", "Unplanned", "Emergency", "Maintenance" });
            cmbOutageType.Location = new Point(40, 220);
            cmbOutageType.Name = "cmbOutageType";
            cmbOutageType.Size = new Size(570, 33);
            cmbOutageType.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDate.Location = new Point(40, 275);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 23);
            lblDate.TabIndex = 5;
            lblDate.Text = "Outage Date:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 11F);
            dtpDate.Location = new Point(40, 305);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(570, 32);
            dtpDate.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(40, 360);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 23);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = BorderStyle.FixedSingle;
            rtbDescription.Font = new Font("Segoe UI", 11F);
            rtbDescription.Location = new Point(40, 390);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(570, 140);
            rtbDescription.TabIndex = 8;
            rtbDescription.Text = "";
            // 
            // lblReportedBy
            // 
            lblReportedBy.AutoSize = true;
            lblReportedBy.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblReportedBy.Location = new Point(40, 545);
            lblReportedBy.Name = "lblReportedBy";
            lblReportedBy.Size = new Size(110, 23);
            lblReportedBy.TabIndex = 9;
            lblReportedBy.Text = "Reported By:";
            // 
            // txtReportedBy
            // 
            txtReportedBy.Font = new Font("Segoe UI", 11F);
            txtReportedBy.Location = new Point(40, 575);
            txtReportedBy.Name = "txtReportedBy";
            txtReportedBy.ReadOnly = true;
            txtReportedBy.Size = new Size(570, 32);
            txtReportedBy.TabIndex = 10;
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(400, 630);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(210, 50);
            btnSave.TabIndex = 11;
            btnSave.Text = "SUBMIT REPORT";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11F);
            btnClear.Location = new Point(290, 630);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 45);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // OutageReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 700);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtReportedBy);
            Controls.Add(lblReportedBy);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cmbOutageType);
            Controls.Add(lblOutageType);
            Controls.Add(cmbLocation);
            Controls.Add(lblLocation);
            Controls.Add(panelHeader);
            Name = "OutageReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report New Outage";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblLocation;
        private ComboBox cmbLocation;
        private Label lblOutageType;
        private ComboBox cmbOutageType;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblReportedBy;
        private TextBox txtReportedBy;
        private Button btnSave;
        private Button btnClear;
        private ErrorProvider errorProvider;
        private Button btnBack;
    }
}
