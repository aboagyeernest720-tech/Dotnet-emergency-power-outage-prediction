using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class OutageStatisticsForm
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
            btnBack = new Button();
            btnRefresh = new Button();
            panelStats = new FlowLayoutPanel();
            pnlTotal = new Panel();
            lblTotalTitle = new Label();
            lblTotalCount = new Label();
            pnlRestored = new Panel();
            lblRestoredTitle = new Label();
            lblRestoredCount = new Label();
            pnlActive = new Panel();
            lblActiveTitle = new Label();
            lblActiveCount = new Label();
            pnlTopLoc = new Panel();
            lblTopLocTitle = new Label();
            lblTopLocation = new Label();
            pnlGridContainer = new TableLayoutPanel();
            grpLocation = new GroupBox();
            dgvLocationStats = new DataGridView();
            grpType = new GroupBox();
            dgvTypeStats = new DataGridView();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlRestored.SuspendLayout();
            pnlActive.SuspendLayout();
            pnlTopLoc.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            grpLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocationStats).BeginInit();
            grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTypeStats).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "OUTAGE ANALYTICS 📈";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(31, 97, 141);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(950, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "← BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(800, 20);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panelStats
            // 
            panelStats.Controls.Add(pnlTotal);
            panelStats.Controls.Add(pnlRestored);
            panelStats.Controls.Add(pnlActive);
            panelStats.Controls.Add(pnlTopLoc);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 80);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20);
            panelStats.Size = new Size(1100, 180);
            panelStats.TabIndex = 1;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotalCount);
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Location = new Point(30, 30);
            pnlTotal.Margin = new Padding(10);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(240, 120);
            pnlTotal.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Dock = DockStyle.Top;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblTotalTitle.ForeColor = Color.Gray;
            lblTotalTitle.Location = new Point(0, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(238, 40);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "TOTAL REPORTS";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCount
            // 
            lblTotalCount.Dock = DockStyle.Fill;
            lblTotalCount.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalCount.Location = new Point(0, 40);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(238, 78);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "0";
            lblTotalCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRestored
            // 
            pnlRestored.BackColor = Color.White;
            pnlRestored.BorderStyle = BorderStyle.FixedSingle;
            pnlRestored.Controls.Add(lblRestoredCount);
            pnlRestored.Controls.Add(lblRestoredTitle);
            pnlRestored.Location = new Point(290, 30);
            pnlRestored.Margin = new Padding(10);
            pnlRestored.Name = "pnlRestored";
            pnlRestored.Size = new Size(240, 120);
            pnlRestored.TabIndex = 1;
            // 
            // lblRestoredTitle
            // 
            lblRestoredTitle.Dock = DockStyle.Top;
            lblRestoredTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblRestoredTitle.ForeColor = Color.Gray;
            lblRestoredTitle.Location = new Point(0, 0);
            lblRestoredTitle.Name = "lblRestoredTitle";
            lblRestoredTitle.Size = new Size(238, 40);
            lblRestoredTitle.TabIndex = 0;
            lblRestoredTitle.Text = "RESTORED";
            lblRestoredTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRestoredCount
            // 
            lblRestoredCount.Dock = DockStyle.Fill;
            lblRestoredCount.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            lblRestoredCount.ForeColor = Color.FromArgb(46, 204, 113);
            lblRestoredCount.Location = new Point(0, 40);
            lblRestoredCount.Name = "lblRestoredCount";
            lblRestoredCount.Size = new Size(238, 78);
            lblRestoredCount.TabIndex = 1;
            lblRestoredCount.Text = "0";
            lblRestoredCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlActive
            // 
            pnlActive.BackColor = Color.White;
            pnlActive.BorderStyle = BorderStyle.FixedSingle;
            pnlActive.Controls.Add(lblActiveCount);
            pnlActive.Controls.Add(lblActiveTitle);
            pnlActive.Location = new Point(550, 30);
            pnlActive.Margin = new Padding(10);
            pnlActive.Name = "pnlActive";
            pnlActive.Size = new Size(240, 120);
            pnlActive.TabIndex = 2;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.Dock = DockStyle.Top;
            lblActiveTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblActiveTitle.ForeColor = Color.Gray;
            lblActiveTitle.Location = new Point(0, 0);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(238, 40);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "ACTIVE OUTAGES";
            lblActiveTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveCount
            // 
            lblActiveCount.Dock = DockStyle.Fill;
            lblActiveCount.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            lblActiveCount.ForeColor = Color.FromArgb(231, 76, 60);
            lblActiveCount.Location = new Point(0, 40);
            lblActiveCount.Name = "lblActiveCount";
            lblActiveCount.Size = new Size(238, 78);
            lblActiveCount.TabIndex = 1;
            lblActiveCount.Text = "0";
            lblActiveCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTopLoc
            // 
            pnlTopLoc.BackColor = Color.White;
            pnlTopLoc.BorderStyle = BorderStyle.FixedSingle;
            pnlTopLoc.Controls.Add(lblTopLocation);
            pnlTopLoc.Controls.Add(lblTopLocTitle);
            pnlTopLoc.Location = new Point(810, 30);
            pnlTopLoc.Margin = new Padding(10);
            pnlTopLoc.Name = "pnlTopLoc";
            pnlTopLoc.Size = new Size(240, 120);
            pnlTopLoc.TabIndex = 3;
            // 
            // lblTopLocTitle
            // 
            lblTopLocTitle.Dock = DockStyle.Top;
            lblTopLocTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblTopLocTitle.ForeColor = Color.Gray;
            lblTopLocTitle.Location = new Point(0, 0);
            lblTopLocTitle.Name = "lblTopLocTitle";
            lblTopLocTitle.Size = new Size(238, 40);
            lblTopLocTitle.TabIndex = 0;
            lblTopLocTitle.Text = "CRITICAL AREA";
            lblTopLocTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopLocation
            // 
            lblTopLocation.Dock = DockStyle.Fill;
            lblTopLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopLocation.ForeColor = Color.FromArgb(243, 156, 18);
            lblTopLocation.Location = new Point(0, 40);
            lblTopLocation.Name = "lblTopLocation";
            lblTopLocation.Size = new Size(238, 78);
            lblTopLocation.TabIndex = 1;
            lblTopLocation.Text = "No Data";
            lblTopLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.ColumnCount = 2;
            pnlGridContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGridContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlGridContainer.Controls.Add(grpLocation, 0, 0);
            pnlGridContainer.Controls.Add(grpType, 1, 0);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 260);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(30);
            pnlGridContainer.RowCount = 2; // Change to 2 rows
            pnlGridContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlGridContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlGridContainer.Size = new Size(1100, 440);
            pnlGridContainer.TabIndex = 2;

            // 
            // pnlPrediction
            // 
            pnlPrediction = new Panel();
            pnlPrediction.BackColor = Color.FromArgb(41, 128, 185);
            pnlPrediction.Controls.Add(lblPrediction);
            pnlPrediction.Dock = DockStyle.Fill;
            pnlPrediction.Location = new Point(40, 310); // Adjust this later or let TableLayoutPanel handle it
            pnlPrediction.Name = "pnlPrediction";
            pnlPrediction.Size = new Size(1020, 80);
            pnlGridContainer.SetColumnSpan(pnlPrediction, 2);
            pnlGridContainer.Controls.Add(pnlPrediction, 0, 1);

            // 
            // lblPrediction
            // 
            lblPrediction = new Label();
            lblPrediction.Dock = DockStyle.Fill;
            lblPrediction.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Bold);
            lblPrediction.ForeColor = Color.White;
            lblPrediction.Text = "Predicting...";
            lblPrediction.TextAlign = ContentAlignment.MiddleCenter;
            pnlPrediction.Controls.Add(lblPrediction);

            // 
            // grpLocation
            // 
            grpLocation.Controls.Add(dgvLocationStats);
            grpLocation.Dock = DockStyle.Fill;
            grpLocation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpLocation.Location = new Point(40, 40);
            grpLocation.Margin = new Padding(10);
            grpLocation.Name = "grpLocation";
            grpLocation.Size = new Size(500, 360);
            grpLocation.TabIndex = 0;
            grpLocation.TabStop = false;
            grpLocation.Text = "Outages by Location";
            // 
            // dgvLocationStats
            // 
            dgvLocationStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocationStats.Dock = DockStyle.Fill;
            dgvLocationStats.Location = new Point(3, 26);
            dgvLocationStats.Name = "dgvLocationStats";
            dgvLocationStats.RowHeadersWidth = 51;
            dgvLocationStats.Size = new Size(494, 331);
            dgvLocationStats.TabIndex = 0;
            // 
            // grpType
            // 
            grpType.Controls.Add(dgvTypeStats);
            grpType.Dock = DockStyle.Fill;
            grpType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpType.Location = new Point(560, 40);
            grpType.Margin = new Padding(10);
            grpType.Name = "grpType";
            grpType.Size = new Size(500, 360);
            grpType.TabIndex = 1;
            grpType.TabStop = false;
            grpType.Text = "Outage Type Distribution";
            // 
            // dgvTypeStats
            // 
            dgvTypeStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypeStats.Dock = DockStyle.Fill;
            dgvTypeStats.Location = new Point(3, 26);
            dgvTypeStats.Name = "dgvTypeStats";
            dgvTypeStats.RowHeadersWidth = 51;
            dgvTypeStats.Size = new Size(494, 331);
            dgvTypeStats.TabIndex = 0;
            // 
            // OutageStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlGridContainer);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OutageStatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Outage Statistics";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlRestored.ResumeLayout(false);
            pnlActive.ResumeLayout(false);
            pnlTopLoc.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            grpLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLocationStats).EndInit();
            grpType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTypeStats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Button btnBack;
        private Button btnRefresh;
        private FlowLayoutPanel panelStats;
        private Panel pnlTotal;
        private Label lblTotalTitle;
        private Label lblTotalCount;
        private Panel pnlRestored;
        private Label lblRestoredTitle;
        private Label lblRestoredCount;
        private Panel pnlActive;
        private Label lblActiveTitle;
        private Label lblActiveCount;
        private Panel pnlTopLoc;
        private Label lblTopLocTitle;
        private Label lblTopLocation;
        private TableLayoutPanel pnlGridContainer;
        private GroupBox grpLocation;
        private DataGridView dgvLocationStats;
        private GroupBox grpType;
        private DataGridView dgvTypeStats;
        private Panel pnlPrediction;
        private Label lblPrediction;
    }
}
