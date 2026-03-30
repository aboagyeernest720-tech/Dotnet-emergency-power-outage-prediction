using SmartPowerOutageSystem.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class RestorationTrackingForm : Form
    {
        private readonly OutageService _outageService = new OutageService();

        public RestorationTrackingForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = _outageService.GetRestorationData();
            
            // Add a column for calculated duration
            if (!dt.Columns.Contains("Duration"))
            {
                dt.Columns.Add("Duration", typeof(string));
            }

            foreach (DataRow row in dt.Rows)
            {
                if (DateTime.TryParse(row["ReportDate"].ToString(), out DateTime start) &&
                    DateTime.TryParse(row["RestorationDate"].ToString(), out DateTime end))
                {
                    TimeSpan span = end - start;
                    row["Duration"] = $"{(int)span.TotalHours}h {span.Minutes}m";
                }
                else
                {
                    row["Duration"] = "N/A";
                }
            }

            dgvRestoration.DataSource = dt;
            
            // Cleanup headers
            dgvRestoration.Columns["ReportDate"].HeaderText = "Reported On";
            dgvRestoration.Columns["RestorationDate"].HeaderText = "Resolved On";
            dgvRestoration.Columns["Duration"].HeaderText = "Time to Restore";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
