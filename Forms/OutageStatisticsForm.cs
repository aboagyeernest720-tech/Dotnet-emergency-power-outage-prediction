using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class OutageStatisticsForm : Form
    {
        private readonly OutageService _outageService = new OutageService();
        private int _pending = 0;
        private int _resolved = 0;
        private DataTable? _locationData;

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
                int total = int.TryParse(stats["TotalOutages"], out int t) ? t : 0;
                _pending  = int.TryParse(stats["ActiveOutages"], out int p) ? p : 0;
                _resolved = int.TryParse(stats["RestoredOutages"], out int r) ? r : 0;

                lblTotalCount.Text    = total.ToString();
                lblPendingCount.Text  = _pending.ToString();
                lblResolvedCount.Text = _resolved.ToString();

                _locationData = _outageService.GetTopLocationsForChart(4);

                pnlPieChart.Invalidate();
                pnlBarChart.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        // Draw a rounded rectangle filled with a color
        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X,                  r.Y,                  radius, radius, 180, 90);
            path.AddArc(r.Right - radius,     r.Y,                  radius, radius, 270, 90);
            path.AddArc(r.Right - radius,     r.Bottom - radius,    radius, radius, 0,   90);
            path.AddArc(r.X,                  r.Bottom - radius,    radius, radius, 90,  90);
            path.CloseFigure();
            return path;
        }

        private void Card_Paint(object? sender, PaintEventArgs e, Color col)
        {
            if (sender is not Panel p) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var r2 = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
            using var path = RoundedRect(r2, 14);
            using var b    = new SolidBrush(col);
            e.Graphics.FillPath(b, path);
        }

        private void PnlPieChart_Paint(object? sender, PaintEventArgs e)
        {
            int total = _pending + _resolved;
            var g = e.Graphics;
            g.SmoothingMode    = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Subtle card border
            using (var borderPen = new Pen(Color.FromArgb(230, 230, 230), 1))
                g.DrawRectangle(borderPen, 0, 0, pnlPieChart.Width - 1, pnlPieChart.Height - 1);

            if (total == 0)
            {
                g.DrawString("No data yet. Reports will appear here after submission.",
                    new Font("Segoe UI", 10), Brushes.Gray, 40, 90);
                return;
            }

            Color cPending  = Color.FromArgb(224, 142,  69);
            Color cResolved = Color.FromArgb( 91, 125, 177);

            // Pie centered vertically in panel
            int pieSize = 190;
            int pieX    = 30;
            int pieY    = (pnlPieChart.Height - pieSize) / 2;
            var rect    = new Rectangle(pieX, pieY, pieSize, pieSize);

            float sweepR = (float)_resolved / total * 360f;
            float sweepP = (float)_pending  / total * 360f;

            using (var bR = new SolidBrush(cResolved))
            using (var bP = new SolidBrush(cPending))
            {
                g.FillPie(bR, rect, -90f, sweepR);
                g.FillPie(bP, rect, -90f + sweepR, sweepP);
            }

            // Thin white separator ring for premium look
            using (var whitePen = new Pen(Color.White, 2.5f))
                g.DrawEllipse(whitePen, rect);

            // In-segment value labels
            int cx = rect.X + rect.Width / 2;
            int cy = rect.Y + rect.Height / 2;
            using var fntSeg = new Font("Segoe UI Bold", 11);

            if (sweepR > 18)
            {
                float ang = (-90f + sweepR / 2f) * (float)Math.PI / 180f;
                float tx  = cx + 52 * (float)Math.Cos(ang);
                float ty  = cy + 52 * (float)Math.Sin(ang);
                g.DrawString(_resolved.ToString(), fntSeg, Brushes.White, tx - 9, ty - 9);
            }
            if (sweepP > 18)
            {
                float ang = (-90f + sweepR + sweepP / 2f) * (float)Math.PI / 180f;
                float tx  = cx + 52 * (float)Math.Cos(ang);
                float ty  = cy + 52 * (float)Math.Sin(ang);
                g.DrawString(_pending.ToString(), fntSeg, Brushes.White, tx - 9, ty - 9);
            }

            // Legend — right side, vertically centered
            int lx   = 260;
            int lyTop = pnlPieChart.Height / 2 - 40;
            using var fntL  = new Font("Segoe UI", 11.5f);
            using var fntB  = new Font("Segoe UI Semibold", 11.5f);
            using var bPen2 = new SolidBrush(cPending);
            using var bRes2 = new SolidBrush(cResolved);
            using var dkBr  = new SolidBrush(Color.FromArgb(70, 70, 70));

            // Pending row
            g.FillEllipse(bPen2, lx, lyTop + 3, 16, 16);
            g.DrawString("Pending",            fntB, Brushes.Black, lx + 28,  lyTop);
            g.DrawString(_pending.ToString(),  fntL, dkBr,          lx + 210, lyTop);

            // Separator line
            using (var sepPen = new Pen(Color.FromArgb(230, 230, 230), 1))
                g.DrawLine(sepPen, lx, lyTop + 38, lx + 300, lyTop + 38);

            // Resolved row
            g.FillEllipse(bRes2, lx, lyTop + 55, 16, 16);
            g.DrawString("Resolved",           fntB, Brushes.Black, lx + 28,  lyTop + 52);
            g.DrawString(_resolved.ToString(), fntL, dkBr,          lx + 210, lyTop + 52);
        }

        private void PnlBarChart_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // White card border
            using (var pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                g.DrawRectangle(pen, 0, 0, pnlBarChart.Width - 1, pnlBarChart.Height - 1);

            if (_locationData == null || _locationData.Rows.Count == 0)
            {
                g.DrawString("No location data yet.", new Font("Segoe UI", 11), Brushes.Gray, 30, 60);
                return;
            }

            // ── Dynamic max scale ──────────────────────────────────────
            int dataMax = 1;
            foreach (DataRow row in _locationData.Rows)
                if (Convert.ToInt32(row["Count"]) > dataMax) dataMax = Convert.ToInt32(row["Count"]);
            // Round up to a nice ceiling (multiples of 5)
            int maxVal = (int)Math.Ceiling(dataMax * 1.3 / 5.0) * 5;
            if (maxVal < 5) maxVal = 5;
            int steps  = Math.Min(maxVal, 6); // number of grid lines
            int stepVal = maxVal / steps;

            int chartLeft   = 55;
            int chartBottom = pnlBarChart.Height - 52;
            int chartTop    = 20;
            int chartRight  = pnlBarChart.Width - 25;
            int h           = chartBottom - chartTop;

            // Y-axis grid lines
            using (var gridPen = new Pen(Color.FromArgb(230, 230, 230), 1))
            using (var fntAxis = new Font("Segoe UI", 8.5f))
            using (var axisBrush = new SolidBrush(Color.FromArgb(150, 150, 150)))
            {
                for (int i = 0; i <= steps; i++)
                {
                    int val = i * stepVal;
                    int y   = chartBottom - val * h / maxVal;
                    g.DrawLine(gridPen, chartLeft, y, chartRight, y);
                    var valStr = val.ToString();
                    var sz2    = g.MeasureString(valStr, fntAxis);
                    g.DrawString(valStr, fntAxis, axisBrush, chartLeft - sz2.Width - 6, y - sz2.Height / 2);
                }
                // Baseline
                using var basePen = new Pen(Color.FromArgb(180, 180, 180), 1.5f);
                g.DrawLine(basePen, chartLeft, chartBottom, chartRight, chartBottom);
            }

            Color[] colors = {
                Color.FromArgb( 91, 125, 177),
                Color.FromArgb(224, 142,  69),
                Color.FromArgb( 93, 160, 113),
                Color.FromArgb(174,  78,  78)
            };

            int n      = _locationData.Rows.Count;
            int barW   = 56;
            int avail  = chartRight - chartLeft;
            int totalBarW = n * barW;
            int totalGap  = avail - totalBarW;
            int gap    = totalGap / (n + 1);
            int startX = chartLeft + gap;

            using var fntLabel = new Font("Segoe UI Semibold", 9);
            using var lblBrush = new SolidBrush(Color.FromArgb(70, 70, 70));
            using var fntVal   = new Font("Segoe UI Bold", 8.5f);

            for (int i = 0; i < n; i++)
            {
                int    count = Convert.ToInt32(_locationData.Rows[i]["Count"]);
                string loc   = (_locationData.Rows[i]["Location"]?.ToString() ?? "").Replace(" Region", "");
                int    barH  = Math.Max(count * h / maxVal, 2);
                int    barX  = startX + i * (barW + gap);
                int    barY  = chartBottom - barH;

                // Rounded-top bar
                using (var path = new GraphicsPath())
                {
                    int r = 6;
                    path.AddArc(barX,         barY,    r, r, 180, 90);
                    path.AddArc(barX + barW - r, barY, r, r, 270, 90);
                    path.AddLine(barX + barW, chartBottom, barX, chartBottom);
                    path.CloseFigure();
                    using var b = new SolidBrush(colors[i % colors.Length]);
                    g.FillPath(b, path);
                }

                // Value above bar
                var valStr = count.ToString();
                var valSz  = g.MeasureString(valStr, fntVal);
                g.DrawString(valStr, fntVal, lblBrush, barX + (barW - valSz.Width) / 2, barY - valSz.Height - 2);

                // Location label below
                var locSz = g.MeasureString(loc, fntLabel);
                g.DrawString(loc, fntLabel, lblBrush, barX + (barW - locSz.Width) / 2, chartBottom + 8);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
