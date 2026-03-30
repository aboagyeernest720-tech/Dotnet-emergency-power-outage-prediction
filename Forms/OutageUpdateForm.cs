using System;
using System.Windows.Forms;
using SmartPowerOutageSystem.Models;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class OutageUpdateForm : Form
    {
        private PowerOutageReport _report;
        private readonly OutageService _outageService = new OutageService();

        public OutageUpdateForm(PowerOutageReport report)
        {
            InitializeComponent();
            _report = report;
            LoadDetails();
        }

        private void LoadDetails()
        {
            lblInfo.Text = $"Updating Report #{_report.ReportID}\n" +
                          $"Location: {_report.Location}\n" +
                          $"Outage Type: {_report.OutageType}\n" +
                          $"Report Date: {_report.ReportDate:f}";

            cmbStatus.SelectedItem = _report.Status;
            
            if (_report.RestorationDate.HasValue)
            {
                chkIsRestored.Checked = true;
                dtpRestorationDate.Value = _report.RestorationDate.Value;
                dtpRestorationDate.Enabled = true;
            }
            else
            {
                chkIsRestored.Checked = false;
                dtpRestorationDate.Value = DateTime.Now;
                dtpRestorationDate.Enabled = false;
            }
        }

        private void chkIsRestored_CheckedChanged(object sender, EventArgs e)
        {
            dtpRestorationDate.Enabled = chkIsRestored.Checked;
            if (chkIsRestored.Checked)
            {
                cmbStatus.SelectedItem = "Restored";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = cmbStatus.SelectedItem?.ToString() ?? "Pending";
            DateTime? restorationDate = chkIsRestored.Checked ? dtpRestorationDate.Value : null;

            if (_outageService.UpdateStatus(_report.ReportID, status, restorationDate))
            {
                MessageBox.Show("Status updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRestored_CheckedChanged(object sender, EventArgs e)
        {
             // Fallback if needed, but the designer is set to use chkIsRestored_CheckedChanged
             chkIsRestored_CheckedChanged(sender, e);
        }
    }
}
