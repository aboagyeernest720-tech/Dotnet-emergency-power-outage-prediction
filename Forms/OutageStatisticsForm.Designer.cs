using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class OutageStatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Controls ──────────────────────────────────────────────────────────
            pnlHeader       = new Panel();
            lblManageLogo   = new Label();
            lblTitle        = new Label();
            lblMinimize     = new Label();
            lblMaximize     = new Label();
            lblClose        = new Label();

            pnlCards        = new Panel();
            pnlTotal        = new Panel();
            lblTotalIcon    = new Label();
            lblTotalLbl     = new Label();
            lblTotalCount   = new Label();

            pnlPending      = new Panel();
            lblPendingIcon  = new Label();
            lblPendingLbl   = new Label();
            lblPendingCount = new Label();

            pnlResolved     = new Panel();
            lblResolvedIcon = new Label();
            lblResolvedLbl  = new Label();
            lblResolvedCount= new Label();

            lblPieTitle     = new Label();
            pnlPieChart     = new Panel();
            lblBarTitle     = new Label();
            pnlBarChart     = new Panel();

            pnlPrediction   = new Panel();
            lblPrediction   = new Label();

            SuspendLayout();

            // ── Form ──────────────────────────────────────────────────────
            Name              = "OutageStatisticsForm";
            Text              = "Manage";
            ClientSize        = new Size(900, 730);
            BackColor         = Color.FromArgb(245, 246, 248);
            FormBorderStyle   = FormBorderStyle.FixedSingle;
            StartPosition     = FormStartPosition.CenterScreen;

            // ── Header bar ───────────────────────────────────────────────
            pnlHeader.BackColor  = Color.White;
            pnlHeader.Size       = new Size(900, 44);
            pnlHeader.Location   = new Point(0, 0);
            pnlHeader.BorderStyle= BorderStyle.None;
            // Drag
            pnlHeader.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                { pnlHeader.Capture = false;
                  var msg = Message.Create(Handle, 0xA1, new System.IntPtr(2), System.IntPtr.Zero);
                  WndProc(ref msg); }
            };

            lblManageLogo.Text      = "⊞";
            lblManageLogo.Font      = new Font("Segoe UI", 15F);
            lblManageLogo.ForeColor = Color.FromArgb(59, 89, 152);
            lblManageLogo.AutoSize  = true;
            lblManageLogo.Location  = new Point(12, 8);

            lblTitle.Text      = "Manage";
            lblTitle.Font      = new Font("Segoe UI", 11F);
            lblTitle.ForeColor = Color.Black;
            lblTitle.AutoSize  = true;
            lblTitle.Location  = new Point(42, 12);

            // Window decorations (non-functional display only)
            lblMinimize.Text      = "─";
            lblMinimize.Font      = new Font("Segoe UI", 11F);
            lblMinimize.ForeColor = Color.Gray;
            lblMinimize.AutoSize  = true;
            lblMinimize.Location  = new Point(806, 10);
            lblMinimize.Cursor    = Cursors.Hand;
            lblMinimize.Click    += (s, e) => this.WindowState = FormWindowState.Minimized;

            lblMaximize.Text      = "□";
            lblMaximize.Font      = new Font("Segoe UI", 11F);
            lblMaximize.ForeColor = Color.Gray;
            lblMaximize.AutoSize  = true;
            lblMaximize.Location  = new Point(840, 10);
            lblMaximize.Cursor    = Cursors.Hand;

            lblClose.Text      = "×";
            lblClose.Font      = new Font("Segoe UI", 13F);
            lblClose.ForeColor = Color.Gray;
            lblClose.AutoSize  = true;
            lblClose.Location  = new Point(868, 8);
            lblClose.Cursor    = Cursors.Hand;
            lblClose.Click    += (s, e) => this.Close();
            lblClose.MouseEnter+= (s, e) => lblClose.ForeColor = Color.Red;
            lblClose.MouseLeave+= (s, e) => lblClose.ForeColor = Color.Gray;

            pnlHeader.Controls.AddRange(new Control[]
                { lblManageLogo, lblTitle, lblMinimize, lblMaximize, lblClose });

            // ── Stat Cards ───────────────────────────────────────────────
            pnlCards.Location  = new Point(20, 60);
            pnlCards.Size      = new Size(860, 140);
            pnlCards.BackColor = Color.Transparent;

            // Total card (blue)
            SetCard(pnlTotal, lblTotalIcon, lblTotalLbl, lblTotalCount,
                    new Point(0, 0), Color.FromArgb(59, 89, 152), "⚡", "Total\r\nOutages");
            pnlTotal.BackColor = Color.Transparent;
            pnlTotal.Paint += (s, e) => Card_Paint(s, e, Color.FromArgb(59, 89, 152));

            // Pending card (orange)
            SetCard(pnlPending, lblPendingIcon, lblPendingLbl, lblPendingCount,
                    new Point(210, 0), Color.FromArgb(211, 131, 59), "⌛", "Pending\r\nOutages");
            pnlPending.BackColor = Color.Transparent;
            pnlPending.Paint += (s, e) => Card_Paint(s, e, Color.FromArgb(211, 131, 59));

            // Resolved card (green)
            SetCard(pnlResolved, lblResolvedIcon, lblResolvedLbl, lblResolvedCount,
                    new Point(420, 0), Color.FromArgb(93, 160, 113), "✔", "Resolved\r\nOutages");
            pnlResolved.BackColor = Color.Transparent;
            pnlResolved.Paint += (s, e) => Card_Paint(s, e, Color.FromArgb(93, 160, 113));

            pnlCards.Controls.AddRange(new Control[] { pnlTotal, pnlPending, pnlResolved });

            // ── Pie section ──────────────────────────────────────────────
            lblPieTitle.Text      = "Outage Status Breakdown";
            lblPieTitle.Font      = new Font("Segoe UI Semibold", 11F);
            lblPieTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblPieTitle.AutoSize  = true;
            lblPieTitle.Location  = new Point(20, 217);

            pnlPieChart.Location   = new Point(20, 244);
            pnlPieChart.Size       = new Size(860, 240);
            pnlPieChart.BackColor  = Color.White;
            pnlPieChart.Paint     += PnlPieChart_Paint;

            // ── Bar section ───────────────────────────────────────────────
            lblBarTitle.Text      = "Outages by Location";
            lblBarTitle.Font      = new Font("Segoe UI Semibold", 11F);
            lblBarTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblBarTitle.AutoSize  = true;
            lblBarTitle.Location  = new Point(20, 500);

            pnlBarChart.Location  = new Point(20, 526);
            pnlBarChart.Size      = new Size(860, 195);
            pnlBarChart.BackColor = Color.White;
            pnlBarChart.Paint    += PnlBarChart_Paint;

            // ── Refresh button ───────────────────────────────────────────
            var btnRefresh       = new Button();
            btnRefresh.Text      = "↺  Refresh";
            btnRefresh.Font      = new Font("Segoe UI", 9F);
            btnRefresh.Location  = new Point(740, 218);
            btnRefresh.Size      = new Size(100, 26);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnRefresh.Cursor    = Cursors.Hand;
            btnRefresh.Click    += btnRefresh_Click;

            // ── Prediction banner ─────────────────────────────────────────
            pnlPrediction.Location  = new Point(20, 670);
            pnlPrediction.Size      = new Size(860, 0); // hidden; kept for compat
            pnlPrediction.BackColor = Color.FromArgb(41, 128, 185);
            lblPrediction.Dock      = DockStyle.Fill;
            lblPrediction.Font      = new Font("Segoe UI Italic", 11F);
            lblPrediction.ForeColor = Color.White;
            lblPrediction.TextAlign = ContentAlignment.MiddleCenter;
            pnlPrediction.Controls.Add(lblPrediction);

            // ── Add to form ───────────────────────────────────────────────
            Controls.AddRange(new Control[]
            {
                pnlHeader,
                pnlCards,
                lblPieTitle, pnlPieChart,
                lblBarTitle, pnlBarChart,
                btnRefresh,
                pnlPrediction
            });

            ResumeLayout(false);
        }

        // Helper: configure a stat card
        private static void SetCard(Panel card, Label icon, Label lbl, Label count,
                                    Point loc, Color bg, string iconText, string labelText)
        {
            card.Location  = loc;
            card.Size      = new Size(190, 130);
            card.BackColor = bg;

            icon.Text      = iconText;
            icon.Font      = new Font("Segoe UI", 26F);
            icon.ForeColor = Color.White;
            icon.AutoSize  = true;
            icon.Location  = new Point(12, 14);

            lbl.Text      = labelText;
            lbl.Font      = new Font("Segoe UI Semibold", 10F);
            lbl.ForeColor = Color.White;
            lbl.Location  = new Point(82, 10);
            lbl.Size      = new Size(100, 55);
            lbl.TextAlign = ContentAlignment.TopRight;

            count.Text      = "0";
            count.Font      = new Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            count.ForeColor = Color.White;
            count.Location  = new Point(10, 78);
            count.Size      = new Size(172, 45);
            count.TextAlign = ContentAlignment.BottomRight;

            card.Controls.AddRange(new Control[] { icon, lbl, count });
        }

        #endregion

        private Panel  pnlHeader;
        private Label  lblManageLogo, lblTitle, lblMinimize, lblMaximize, lblClose;
        private Panel  pnlCards;
        private Panel  pnlTotal;
        private Label  lblTotalIcon, lblTotalLbl, lblTotalCount;
        private Panel  pnlPending;
        private Label  lblPendingIcon, lblPendingLbl, lblPendingCount;
        private Panel  pnlResolved;
        private Label  lblResolvedIcon, lblResolvedLbl, lblResolvedCount;
        private Label  lblPieTitle;
        private Panel  pnlPieChart;
        private Label  lblBarTitle;
        private Panel  pnlBarChart;
        private Panel  pnlPrediction;
        private Label  lblPrediction;
    }
}
