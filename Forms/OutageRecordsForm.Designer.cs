using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class OutageRecordsForm
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
            dgvRecords = new DataGridView();
            panelActions = new Panel();
            btnUpdateStatus = new Button();
            btnShowSummary = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnBack = new Button();
            lblSearch = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 45, 62);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 80);
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
            lblTitle.Size = new Size(295, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "OUTAGE RECORDS";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvRecords);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 160);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(1100, 590);
            panelContent.TabIndex = 1;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = Color.White;
            dgvRecords.ColumnHeadersHeight = 40;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecords.Dock = DockStyle.Fill;
            dgvRecords.Location = new Point(25, 25);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(1050, 540);
            dgvRecords.TabIndex = 0;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.BorderStyle = BorderStyle.FixedSingle;
            panelActions.Controls.Add(btnUpdateStatus);
            panelActions.Controls.Add(btnShowSummary);
            panelActions.Controls.Add(btnDelete);
            panelActions.Controls.Add(btnRefresh);
            panelActions.Controls.Add(txtSearch);
            panelActions.Controls.Add(btnSearch);
            panelActions.Controls.Add(lblSearch);
            panelActions.Dock = DockStyle.Top;
            panelActions.Location = new Point(0, 80);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1100, 80);
            panelActions.TabIndex = 2;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStatus.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(720, 22);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(120, 35);
            btnUpdateStatus.TabIndex = 6;
            btnUpdateStatus.Text = "Edit Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnShowSummary
            // 
            btnShowSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowSummary.BackColor = Color.FromArgb(103, 58, 183);
            btnShowSummary.FlatStyle = FlatStyle.Flat;
            btnShowSummary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnShowSummary.ForeColor = Color.White;
            btnShowSummary.Location = new Point(585, 22);
            btnShowSummary.Name = "btnShowSummary";
            btnShowSummary.Size = new Size(120, 35);
            btnShowSummary.TabIndex = 5;
            btnShowSummary.Text = "Summary";
            btnShowSummary.UseVisualStyleBackColor = false;
            btnShowSummary.Click += btnShowSummary_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(960, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F);
            btnRefresh.ForeColor = Color.FromArgb(71, 85, 105);
            btnRefresh.Location = new Point(850, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "⟳ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(100, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type location or status...";
            txtSearch.Size = new Size(320, 32);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += btnSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(430, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(30, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(65, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // OutageRecordsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1100, 750);
            Controls.Add(panelContent);
            Controls.Add(panelActions);
            Controls.Add(panelHeader);
            Name = "OutageRecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Outage Records Viewer";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private DataGridView dgvRecords;
        private Panel panelActions;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnShowSummary;
        private Button btnUpdateStatus;
    }
}
