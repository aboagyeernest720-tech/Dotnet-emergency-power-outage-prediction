using SmartPowerOutageSystem.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class SystemStatisticsForm : Form
    {
        private readonly OutageService _outageService = new OutageService();

        public SystemStatisticsForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                var stats = _outageService.GetStatistics();
                
                lblTotalVal.Text = stats.ContainsKey("TotalOutages") ? stats["TotalOutages"] : "0";
                lblRestoredVal.Text = stats.ContainsKey("RestoredOutages") ? stats["RestoredOutages"] : "0";
                lblActiveVal.Text = stats.ContainsKey("ActiveOutages") ? stats["ActiveOutages"] : "0";
                lblPeakLocVal.Text = stats.ContainsKey("TopLocation") ? stats["TopLocation"] : "N/A";

                lblPredictionText.Text = _outageService.PredictNextOutage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
