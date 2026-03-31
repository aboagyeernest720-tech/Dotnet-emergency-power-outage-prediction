using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private string _username;
        private string _role;
        private UserService _userService = new UserService();
        private OutageService _outageService = new OutageService();

        public AdminDashboardForm(string username)
        {
            InitializeComponent();
            _username = username;
            _role = "Administrator";
            lblWelcome.Text = $"Welcome, Admin";
            
            // Round corners simulation or just nice borders
            ConfigureGrids();
            LoadStatistics();
            btnReport.Click += btnReport_Click;
        }

        private void btnReport_Click(object? sender, EventArgs e)
        {
            new OutageReportForm(_username).ShowDialog();
            LoadStatistics();
        }

        private void ConfigureGrids()
        {
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvRecent.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9);
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.ReadOnly = true;
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.RowTemplate.Height = 40;
            dgvRecent.GridColor = Color.FromArgb(241, 245, 249);
            dgvRecent.CellFormatting += DgvRecent_CellFormatting;
            dgvRecent.DataBindingComplete += (s, e) => {
                if (dgvRecent.Columns.Contains("Location")) dgvRecent.Columns["Location"].FillWeight = 150;
                if (dgvRecent.Columns.Contains("ID")) dgvRecent.Columns["ID"].Width = 40;
                if (dgvRecent.Columns.Contains("Status")) dgvRecent.Columns["Status"].Width = 100;
            };
        }

        private void DgvRecent_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRecent.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString()!;
                if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11);
                    e.CellStyle.BackColor = Color.FromArgb(254, 243, 199);
                }
                else if (status == "Restored" || status == "Resolved")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(16, 185, 129);
                    e.CellStyle.BackColor = Color.FromArgb(209, 250, 229);
                }
            }
        }

        private void LoadStatistics()
        {
            try
            {
                var counts = _outageService.GetDashboardCounts();
                lblTotalVal.Text = counts["Total"].ToString("D2");
                lblPendingVal.Text = counts["Pending"].ToString("D2");
                lblResolvedVal.Text = counts["Resolved"].ToString("D2");
                lblTodayVal.Text = counts["Today"].ToString("D2");

                dgvRecent.DataSource = _outageService.GetRecentReports(5);
                
                // Optional: Draw simple bars in pnlChart or similar
                CreateSimpleChart();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading stats: " + ex.Message);
            }
        }

        private void CreateSimpleChart()
        {
            pnlChart.Controls.Clear();
            pnlChart.Controls.Add(lblChartTitle);

            var chartData = _outageService.GetTopLocationsForChart(5);
            if (chartData.Rows.Count == 0) return;

            int maxCount = 0;
            foreach (System.Data.DataRow row in chartData.Rows)
                maxCount = Math.Max(maxCount, Convert.ToInt32(row["Count"]));

            int startX = 20;
            int startY = 200; 
            int barWidth = 60; 
            int spacing = 35;
            int maxHeight = 140;

            Color[] colors = { Color.FromArgb(37, 99, 235), Color.FromArgb(16, 185, 129), Color.FromArgb(239, 68, 68), Color.FromArgb(168, 85, 247), Color.FromArgb(245, 158, 11) };

            for (int i = 0; i < chartData.Rows.Count; i++)
            {
                int count = Convert.ToInt32(chartData.Rows[i]["Count"]);
                string loc = chartData.Rows[i]["Location"]?.ToString() ?? "Unknown";
                
                string displayLoc = loc.Replace(" Region", "");
                if (displayLoc.Length > 12) displayLoc = displayLoc.Substring(0, 10) + "..";

                int barHeight = (int)((double)count / (maxCount == 0 ? 1 : maxCount) * maxHeight);

                Panel bar = new Panel
                {
                    BackColor = colors[i % colors.Length],
                    Size = new Size(barWidth, barHeight),
                    Location = new Point(startX + (barWidth + spacing) * i, startY - barHeight)
                };
                pnlChart.Controls.Add(bar);

                Label lblLoc = new Label
                {
                    Text = displayLoc,
                    AutoSize = false,
                    Size = new Size(barWidth + 25, 40),
                    Location = new Point(startX + (barWidth + spacing) * i - 10, startY + 5),
                    Font = new Font("Segoe UI Semibold", 8),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    TextAlign = ContentAlignment.TopCenter
                };
                pnlChart.Controls.Add(lblLoc);

                Label lblVal = new Label
                {
                    Text = count.ToString(),
                    AutoSize = false,
                    Size = new Size(barWidth, 20),
                    Location = new Point(startX + (barWidth + spacing) * i, startY - barHeight - 20),
                    Font = new Font("Segoe UI Bold", 9),
                    TextAlign = ContentAlignment.BottomCenter
                };
                pnlChart.Controls.Add(lblVal);
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            new UserManagementForm().ShowDialog();
            LoadStatistics();
        }

        private void btnLocationManagement_Click(object sender, EventArgs e)
        {
            new LocationManagementForm().ShowDialog();
        }

        private void btnOutageRecords_Click(object sender, EventArgs e)
        {
            new OutageRecordsForm(_role).ShowDialog();
            LoadStatistics();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new OutageStatisticsForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
