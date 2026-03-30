using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class SystemStatisticsForm
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
            panelStats = new FlowLayoutPanel();
            grpTotal = new Panel();
            lblTotalVal = new Label();
            lblTotalTitle = new Label();
            grpRestored = new Panel();
            lblRestoredVal = new Label();
            lblRestoredTitle = new Label();
            grpActive = new Panel();
            lblActiveVal = new Label();
            lblActiveTitle = new Label();
            grpPeakLoc = new Panel();
            lblPeakLocVal = new Label();
            lblPeakLocTitle = new Label();
            panelPrediction = new Panel();
            lblPredictionText = new Label();
            lblPredictionTitle = new Label();
            btnRefresh = new Button();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            grpTotal.SuspendLayout();
            grpRestored.SuspendLayout();
            grpActive.SuspendLayout();
            grpPeakLoc.SuspendLayout();
            panelPrediction.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(63, 81, 181);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(840, 20);
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
            lblTitle.Size = new Size(415, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STATISTICS & PREDICTIONS";
            // 
            // panelStats
            // 
            panelStats.Controls.Add(grpTotal);
            panelStats.Controls.Add(grpRestored);
            panelStats.Controls.Add(grpActive);
            panelStats.Controls.Add(grpPeakLoc);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 80);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20);
            panelStats.Size = new Size(1000, 200);
            panelStats.TabIndex = 1;
            // 
            // grpTotal
            // 
            grpTotal.BackColor = Color.White;
            grpTotal.BorderStyle = BorderStyle.FixedSingle;
            grpTotal.Controls.Add(lblTotalVal);
            grpTotal.Controls.Add(lblTotalTitle);
            grpTotal.Location = new Point(30, 30);
            grpTotal.Margin = new Padding(10);
            grpTotal.Name = "grpTotal";
            grpTotal.Size = new Size(220, 130);
            grpTotal.TabIndex = 0;
            // 
            // lblTotalVal
            // 
            lblTotalVal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalVal.ForeColor = Color.FromArgb(33, 150, 243);
            lblTotalVal.Location = new Point(0, 50);
            lblTotalVal.Name = "lblTotalVal";
            lblTotalVal.Size = new Size(218, 54);
            lblTotalVal.TabIndex = 1;
            lblTotalVal.Text = "0";
            lblTotalVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Dock = DockStyle.Top;
            lblTotalTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalTitle.Location = new Point(0, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Padding = new Padding(0, 10, 0, 0);
            lblTotalTitle.Size = new Size(218, 40);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Reports";
            lblTotalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpRestored
            // 
            grpRestored.BackColor = Color.White;
            grpRestored.BorderStyle = BorderStyle.FixedSingle;
            grpRestored.Controls.Add(lblRestoredVal);
            grpRestored.Controls.Add(lblRestoredTitle);
            grpRestored.Location = new Point(270, 30);
            grpRestored.Margin = new Padding(10);
            grpRestored.Name = "grpRestored";
            grpRestored.Size = new Size(220, 130);
            grpRestored.TabIndex = 1;
            // 
            // lblRestoredVal
            // 
            lblRestoredVal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblRestoredVal.ForeColor = Color.FromArgb(76, 175, 80);
            lblRestoredVal.Location = new Point(0, 50);
            lblRestoredVal.Name = "lblRestoredVal";
            lblRestoredVal.Size = new Size(218, 54);
            lblRestoredVal.TabIndex = 1;
            lblRestoredVal.Text = "0";
            lblRestoredVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRestoredTitle
            // 
            lblRestoredTitle.Dock = DockStyle.Top;
            lblRestoredTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRestoredTitle.Location = new Point(0, 0);
            lblRestoredTitle.Name = "lblRestoredTitle";
            lblRestoredTitle.Padding = new Padding(0, 10, 0, 0);
            lblRestoredTitle.Size = new Size(218, 40);
            lblRestoredTitle.TabIndex = 0;
            lblRestoredTitle.Text = "Fully Restored";
            lblRestoredTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpActive
            // 
            grpActive.BackColor = Color.White;
            grpActive.BorderStyle = BorderStyle.FixedSingle;
            grpActive.Controls.Add(lblActiveVal);
            grpActive.Controls.Add(lblActiveTitle);
            grpActive.Location = new Point(510, 30);
            grpActive.Margin = new Padding(10);
            grpActive.Name = "grpActive";
            grpActive.Size = new Size(220, 130);
            grpActive.TabIndex = 2;
            // 
            // lblActiveVal
            // 
            lblActiveVal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblActiveVal.ForeColor = Color.FromArgb(244, 67, 54);
            lblActiveVal.Location = new Point(0, 50);
            lblActiveVal.Name = "lblActiveVal";
            lblActiveVal.Size = new Size(218, 54);
            lblActiveVal.TabIndex = 1;
            lblActiveVal.Text = "0";
            lblActiveVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.Dock = DockStyle.Top;
            lblActiveTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblActiveTitle.Location = new Point(0, 0);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Padding = new Padding(0, 10, 0, 0);
            lblActiveTitle.Size = new Size(218, 40);
            lblActiveTitle.TabIndex = 0;
            lblActiveTitle.Text = "Ongoing Outages";
            lblActiveTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpPeakLoc
            // 
            grpPeakLoc.BackColor = Color.White;
            grpPeakLoc.BorderStyle = BorderStyle.FixedSingle;
            grpPeakLoc.Controls.Add(lblPeakLocVal);
            grpPeakLoc.Controls.Add(lblPeakLocTitle);
            grpPeakLoc.Location = new Point(750, 30);
            grpPeakLoc.Margin = new Padding(10);
            grpPeakLoc.Name = "grpPeakLoc";
            grpPeakLoc.Size = new Size(220, 130);
            grpPeakLoc.TabIndex = 3;
            // 
            // lblPeakLocVal
            // 
            lblPeakLocVal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPeakLocVal.ForeColor = Color.FromArgb(255, 152, 0);
            lblPeakLocVal.Location = new Point(0, 50);
            lblPeakLocVal.Name = "lblPeakLocVal";
            lblPeakLocVal.Size = new Size(218, 64);
            lblPeakLocVal.TabIndex = 1;
            lblPeakLocVal.Text = "No Data";
            lblPeakLocVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPeakLocTitle
            // 
            lblPeakLocTitle.Dock = DockStyle.Top;
            lblPeakLocTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPeakLocTitle.Location = new Point(0, 0);
            lblPeakLocTitle.Name = "lblPeakLocTitle";
            lblPeakLocTitle.Padding = new Padding(0, 10, 0, 0);
            lblPeakLocTitle.Size = new Size(218, 40);
            lblPeakLocTitle.TabIndex = 0;
            lblPeakLocTitle.Text = "Peak Location";
            lblPeakLocTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPrediction
            // 
            panelPrediction.BackColor = Color.FromArgb(232, 234, 246);
            panelPrediction.BorderStyle = BorderStyle.FixedSingle;
            panelPrediction.Controls.Add(lblPredictionText);
            panelPrediction.Controls.Add(lblPredictionTitle);
            panelPrediction.Location = new Point(30, 310);
            panelPrediction.Name = "panelPrediction";
            panelPrediction.Size = new Size(940, 160);
            panelPrediction.TabIndex = 2;
            // 
            // lblPredictionText
            // 
            lblPredictionText.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblPredictionText.ForeColor = Color.FromArgb(26, 35, 126);
            lblPredictionText.Location = new Point(20, 70);
            lblPredictionText.Name = "lblPredictionText";
            lblPredictionText.Size = new Size(900, 70);
            lblPredictionText.TabIndex = 1;
            lblPredictionText.Text = "Calculating next probable outage...";
            lblPredictionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPredictionTitle
            // 
            lblPredictionTitle.AutoSize = true;
            lblPredictionTitle.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblPredictionTitle.ForeColor = Color.FromArgb(63, 81, 181);
            lblPredictionTitle.Location = new Point(20, 20);
            lblPredictionTitle.Name = "lblPredictionTitle";
            lblPredictionTitle.Size = new Size(281, 32);
            lblPredictionTitle.TabIndex = 0;
            lblPredictionTitle.Text = "SMART PREDICTION 🧠";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(224, 224, 224);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(30, 500);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // SystemStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(btnRefresh);
            Controls.Add(panelPrediction);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);
            Name = "SystemStatisticsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Outage Statistics & Intelligence";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            grpTotal.ResumeLayout(false);
            grpRestored.ResumeLayout(false);
            grpActive.ResumeLayout(false);
            grpPeakLoc.ResumeLayout(false);
            panelPrediction.ResumeLayout(false);
            panelPrediction.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private FlowLayoutPanel panelStats;
        private Panel grpTotal;
        private Label lblTotalTitle;
        private Label lblTotalVal;
        private Panel grpRestored;
        private Label lblRestoredVal;
        private Label lblRestoredTitle;
        private Panel grpActive;
        private Label lblActiveVal;
        private Label lblActiveTitle;
        private Panel grpPeakLoc;
        private Label lblPeakLocVal;
        private Label lblPeakLocTitle;
        private Panel panelPrediction;
        private Label lblPredictionTitle;
        private Label lblPredictionText;
        private Button btnRefresh;
        private Button btnBack;
    }
}
