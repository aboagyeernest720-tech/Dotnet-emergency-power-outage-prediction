using SmartPowerOutageSystem.Models;
using SmartPowerOutageSystem.Services;
using System.Data;

namespace SmartPowerOutageSystem.Forms
{
    public partial class OutageReportForm : Form
    {
        private string _currentUser;
        private readonly OutageService _outageService = new OutageService();

        public OutageReportForm(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            txtReportedBy.Text = _currentUser;
            dtpDate.Value = DateTime.Now;
            LoadLocations();
        }

        private void LoadLocations()
        {
            try
            {
                var service = new LocationService();
                var dt = service.GetAllLocations();
                cmbLocation.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbLocation.Items.Add(row["LocationName"]?.ToString() ?? "Unknown");
                }
            }
            catch (Exception ex)
            {
                // Non-fatal error, just means list might be empty
                System.Diagnostics.Debug.WriteLine("LoadLocations error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    var report = new PowerOutageReport
                    {
                        Location = cmbLocation.Text.Trim(),
                        ReportDate = dtpDate.Value,
                        OutageType = cmbOutageType.Text.Trim(),
                        Description = rtbDescription.Text.Trim(),
                        ReportedBy = txtReportedBy.Text.Trim(),
                        Status = "Pending"
                    };

                    if (_outageService.SaveReport(report))
                    {
                        // Notify managers
                        var uService = new UserService();
                        var nService = new NotificationService();
                        foreach (var manager in uService.GetUsersByRole("Manager"))
                        {
                            nService.SendNotification(manager, $"Urgent: A new {report.OutageType} outage report was just submitted for {report.Location}.");
                        }

                        MessageBox.Show("Power outage report submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save report. Please check database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"System error while saving: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(cmbLocation.Text))
            {
                errorProvider.SetError(cmbLocation, "Location is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cmbOutageType.Text))
            {
                errorProvider.SetError(cmbOutageType, "Outage type is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                errorProvider.SetError(rtbDescription, "Description is required.");
                isValid = false;
            }

            return isValid;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbLocation.SelectedIndex = -1;
            cmbOutageType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            rtbDescription.Clear();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
