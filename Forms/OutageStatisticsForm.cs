using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class OutageStatisticsForm : Form
    {
        private readonly OutageService _outageService = new OutageService();

        public OutageStatisticsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var stats = _outageService.GetStatistics();
                lblTotalCount.Text = stats["TotalOutages"];
                lblRestoredCount.Text = stats["RestoredOutages"];
                lblActiveCount.Text = stats["ActiveOutages"];
                lblTopLocation.Text = stats["TopLocation"];
                lblPrediction.Text = "🔮 SMART PREDICTION: " + _outageService.PredictNextOutage();

                pnlPieChart.Refresh();
                pnlBarChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PnlPieChart_Paint(object? sender, PaintEventArgs e)
        {
            var counts = _outageService.GetDashboardCounts();
            int pending = counts["Pending"];
            int resolved = counts["Resolved"];
            int total = pending + resolved;
            if (total == 0) return;

            float sweepP = (float)pending / total * 360f;
            float sweepR = (float)resolved / total * 360f;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(10, 10, 200, 200);

            using (Brush bP = new SolidBrush(Color.FromArgb(211, 131, 59)))
            using (Brush bR = new SolidBrush(Color.FromArgb(93, 160, 113)))
            {
                e.Graphics.FillPie(bR, rect, 0, sweepR);
                e.Graphics.FillPie(bP, rect, sweepR, sweepP);
            }

            // Legend
            int lx = 240, ly = 50;
            using (Brush bP = new SolidBrush(Color.FromArgb(211, 131, 59)))
            using (Brush bR = new SolidBrush(Color.FromArgb(93, 160, 113)))
            {
                e.Graphics.FillEllipse(bP, lx, ly, 15, 15);
                e.Graphics.DrawString($"Pending      {pending}", new Font("Segoe UI", 10), Brushes.Black, lx + 25, ly - 2);
                
                e.Graphics.FillEllipse(bR, lx, ly + 40, 15, 15);
                e.Graphics.DrawString($"Resolved     {resolved}", new Font("Segoe UI", 10), Brushes.Black, lx + 25, ly + 38);
            }
            
            // Value labels on chart segments (if large enough)
            if (sweepR > 20) {
                 float angle = sweepR / 2;
                 double rad = angle * Math.PI / 180;
                 float tx = (float)(rect.X + rect.Width/2 + 60 * Math.Cos(rad));
                 float ty = (float)(rect.Y + rect.Height/2 + 60 * Math.Sin(rad));
                 e.Graphics.DrawString(resolved.ToString(), new Font("Segoe UI Bold", 10), Brushes.White, tx-5, ty-5);
            }
        }

        private void PnlBarChart_Paint(object? sender, PaintEventArgs e)
        {
            var data = _outageService.GetTopLocationsForChart(4); // Match screenshot count
            if (data.Rows.Count == 0) return;

            int max = 0;
            foreach (DataRow row in data.Rows) max = Math.Max(max, Convert.ToInt32(row["Count"]));
            if (max < 30) max = 30; // Match screenshot scale

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int h = pnlBarChart.Height - 60;
            int w = pnlBarChart.Width;

            // Draw Y-axis lines
            using (Pen p = new Pen(Color.FromArgb(241, 245, 249), 1))
            {
                for (int i = 0; i <= 6; i++)
                {
                    int y = h - (i * h / 6) + 10;
                    e.Graphics.DrawLine(p, 40, y, w - 20, y);
                    e.Graphics.DrawString((i * 5).ToString(), new Font("Segoe UI", 8), Brushes.Gray, 10, y - 8);
                }
            }

            int barWidth = 60;
            int spacing = 80;
            int startX = 60;
            Color[] colors = { Color.FromArgb(59, 89, 152), Color.FromArgb(211, 131, 59), Color.FromArgb(93, 160, 113), Color.FromArgb(174, 78, 78) };

            for (int i = 0; i < data.Rows.Count; i++)
            {
                int count = Convert.ToInt32(data.Rows[i]["Count"]);
                string loc = data.Rows[i]["Location"].ToString()!.Replace(" Region", "");
                int barHeight = (int)((double)count / max * h);

                using (Brush b = new SolidBrush(colors[i % colors.Length]))
                {
                    e.Graphics.FillRectangle(b, startX + (barWidth + spacing) * i, h - barHeight + 10, barWidth, barHeight);
                }

                e.Graphics.DrawString(loc, new Font("Segoe UI", 8), Brushes.Black, startX + (barWidth + spacing) * i - 10, h + 20);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
