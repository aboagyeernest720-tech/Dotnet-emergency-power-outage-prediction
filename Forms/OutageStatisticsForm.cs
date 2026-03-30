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
                // 1. Summary Stats
                var stats = _outageService.GetStatistics();
                lblTotalCount.Text = stats["TotalOutages"];
                lblRestoredCount.Text = stats["RestoredOutages"];
                lblActiveCount.Text = stats["ActiveOutages"];
                lblTopLocation.Text = stats["TopLocation"];
                lblPrediction.Text = "🔮 SMART PREDICTION: " + _outageService.PredictNextOutage();

                // 2. Data Tables
                dgvLocationStats.DataSource = _outageService.GetOutagesPerLocation();
                dgvTypeStats.DataSource = _outageService.GetOutageTypeStats();

                // Style GridViews
                StyleGrid(dgvLocationStats);
                StyleGrid(dgvTypeStats);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
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
