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
            lblTotalIcon = new Label();
            pnlRestored = new Panel();
            lblRestoredTitle = new Label();
            lblRestoredCount = new Label();
            lblRestoredIcon = new Label();
            pnlActive = new Panel();
            lblActiveTitle = new Label();
            lblActiveCount = new Label();
            lblActiveIcon = new Label();
            pnlTopLoc = new Panel();
            lblTopLocTitle = new Label();
            lblTopLocation = new Label();
            pnlGridContainer = new TableLayoutPanel();
            pnlPieContainer = new Panel();
            lblPieTitle = new Label();
            pnlPieChart = new Panel();
            pnlBarContainer = new Panel();
            lblBarTitle = new Label();
            pnlBarChart = new Panel();
            pnlPrediction = new Panel();
            lblPrediction = new Label();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlRestored.SuspendLayout();
            pnlActive.SuspendLayout();
            pnlTopLoc.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            SuspendLayout();
            panelHeader.BackColor = Color.FromArgb(17, 33, 51);
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Statistics";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.BackColor = Color.FromArgb(51, 65, 85);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(950, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 45);
            btnBack.TabIndex = 1;
            btnBack.Text = "← BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(37, 99, 235);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(800, 27);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(130, 45);
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
            pnlTotal.BackColor = Color.FromArgb(59, 89, 152);
            pnlTotal.Controls.Add(lblTotalCount);
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Controls.Add(lblTotalIcon);
            pnlTotal.Location = new Point(30, 30);
            pnlTotal.Margin = new Padding(10);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(240, 140);
            pnlTotal.TabIndex = 0;

            lblTotalIcon.AutoSize = true;
            lblTotalIcon.Font = new Font("Segoe UI", 28F);
            lblTotalIcon.ForeColor = Color.White;
            lblTotalIcon.Location = new Point(15, 15);
            lblTotalIcon.Text = "⚡";

            lblTotalTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblTotalTitle.ForeColor = Color.White;
            lblTotalTitle.Location = new Point(90, 15);
            lblTotalTitle.Size = new Size(130, 60);
            lblTotalTitle.Text = "Total\r\nOutages";
            lblTotalTitle.TextAlign = ContentAlignment.TopRight;

            lblTotalCount.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.White;
            lblTotalCount.Location = new Point(30, 75);
            lblTotalCount.Size = new Size(190, 60);
            lblTotalCount.Text = "102";
            lblTotalCount.TextAlign = ContentAlignment.BottomRight;
            // 
            // pnlRestored
            // 
            pnlRestored.BackColor = Color.FromArgb(93, 160, 113);
            pnlRestored.Controls.Add(lblRestoredCount);
            pnlRestored.Controls.Add(lblRestoredTitle);
            pnlRestored.Controls.Add(lblRestoredIcon);
            pnlRestored.Location = new Point(550, 30);
            pnlRestored.Margin = new Padding(10);
            pnlRestored.Name = "pnlRestored";
            pnlRestored.Size = new Size(240, 140);
            pnlRestored.TabIndex = 2;

            lblRestoredIcon.AutoSize = true;
            lblRestoredIcon.Font = new Font("Segoe UI", 28F);
            lblRestoredIcon.ForeColor = Color.White;
            lblRestoredIcon.Location = new Point(15, 15);
            lblRestoredIcon.Text = "✔";

            lblRestoredTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblRestoredTitle.ForeColor = Color.White;
            lblRestoredTitle.Location = new Point(90, 15);
            lblRestoredTitle.Size = new Size(130, 60);
            lblRestoredTitle.Text = "Resolved\r\nOutages";
            lblRestoredTitle.TextAlign = ContentAlignment.TopRight;

            lblRestoredCount.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            lblRestoredCount.ForeColor = Color.White;
            lblRestoredCount.Location = new Point(30, 75);
            lblRestoredCount.Size = new Size(190, 60);
            lblRestoredCount.Text = "77";
            lblRestoredCount.TextAlign = ContentAlignment.BottomRight;
            // 
            // pnlActive
            // 
            pnlActive.BackColor = Color.FromArgb(211, 131, 59);
            pnlActive.Controls.Add(lblActiveCount);
            pnlActive.Controls.Add(lblActiveTitle);
            pnlActive.Controls.Add(lblActiveIcon);
            pnlActive.Location = new Point(290, 30);
            pnlActive.Margin = new Padding(10);
            pnlActive.Name = "pnlActive";
            pnlActive.Size = new Size(240, 140);
            pnlActive.TabIndex = 1;

            lblActiveIcon.AutoSize = true;
            lblActiveIcon.Font = new Font("Segoe UI", 28F);
            lblActiveIcon.ForeColor = Color.White;
            lblActiveIcon.Location = new Point(15, 15);
            lblActiveIcon.Text = "⌛";

            lblActiveTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblActiveTitle.ForeColor = Color.White;
            lblActiveTitle.Location = new Point(90, 15);
            lblActiveTitle.Size = new Size(130, 60);
            lblActiveTitle.Text = "Pending\r\nOutages";
            lblActiveTitle.TextAlign = ContentAlignment.TopRight;

            lblActiveCount.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            lblActiveCount.ForeColor = Color.White;
            lblActiveCount.Location = new Point(30, 75);
            lblActiveCount.Size = new Size(190, 60);
            lblActiveCount.Text = "25";
            lblActiveCount.TextAlign = ContentAlignment.BottomRight;
            // 
            // pnlTopLoc
            // 
            pnlTopLoc.BackColor = Color.White;
            pnlTopLoc.BorderStyle = BorderStyle.None;
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
            pnlGridContainer.ColumnCount = 1;
            pnlGridContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlGridContainer.Controls.Add(pnlPieContainer, 0, 0);
            pnlGridContainer.Controls.Add(pnlBarContainer, 0, 1);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 260);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(30);
            pnlGridContainer.RowCount = 2;
            pnlGridContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            pnlGridContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            pnlGridContainer.Size = new Size(1100, 740); // Increased Height
            pnlGridContainer.TabIndex = 2;

            pnlPieContainer = new Panel();
            pnlPieContainer.BackColor = Color.White;
            pnlPieContainer.Dock = DockStyle.Fill;
            pnlPieContainer.Margin = new Padding(10);
            pnlPieContainer.Controls.Add(lblPieTitle);
            pnlPieContainer.Controls.Add(pnlPieChart);

            lblPieTitle.Text = "Outage Status Breakdown";
            lblPieTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblPieTitle.Location = new Point(10, 10);
            lblPieTitle.Size = new Size(300, 30);

            pnlPieChart = new Panel();
            pnlPieChart.Location = new Point(30, 45);
            pnlPieChart.Size = new Size(400, 250);
            pnlPieChart.Paint += PnlPieChart_Paint;

            pnlBarContainer = new Panel();
            pnlBarContainer.BackColor = Color.White;
            pnlBarContainer.Dock = DockStyle.Fill;
            pnlBarContainer.Margin = new Padding(10);
            pnlBarContainer.Controls.Add(lblBarTitle);
            pnlBarContainer.Controls.Add(pnlBarChart);

            lblBarTitle.Text = "Outages by Location";
            lblBarTitle.Font = new Font("Segoe UI Semibold", 12F);
            lblBarTitle.Location = new Point(10, 10);
            lblBarTitle.Size = new Size(300, 30);

            pnlBarChart = new Panel();
            pnlBarChart.Location = new Point(30, 45);
            pnlBarChart.Size = new Size(950, 300);
            pnlBarChart.Paint += PnlBarChart_Paint;

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

            // Legacy grids removed
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
        private Label lblTotalIcon;
        private Panel pnlRestored;
        private Label lblRestoredTitle;
        private Label lblRestoredCount;
        private Label lblRestoredIcon;
        private Panel pnlActive;
        private Label lblActiveTitle;
        private Label lblActiveCount;
        private Label lblActiveIcon;
        private Panel pnlTopLoc;
        private Label lblTopLocTitle;
        private Label lblTopLocation;
        private TableLayoutPanel pnlGridContainer;
        private Panel pnlPieContainer;
        private Label lblPieTitle;
        private Panel pnlPieChart;
        private Panel pnlBarContainer;
        private Label lblBarTitle;
        private Panel pnlBarChart;
        private Panel pnlPrediction;
        private Label lblPrediction;
    }
}
