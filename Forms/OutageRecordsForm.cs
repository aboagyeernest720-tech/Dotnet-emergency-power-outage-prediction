using SmartPowerOutageSystem.Models;
using SmartPowerOutageSystem.Services;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class OutageRecordsForm : Form
    {
        private readonly OutageService _outageService = new OutageService();
        private List<PowerOutageReport> _allReports = new List<PowerOutageReport>();

        private string _role;

        public OutageRecordsForm(string role = "Administrator")
        {
            InitializeComponent();
            _role = role;
            LoadData();

            if (_role == "User")
            {
                btnDelete.Visible = false;
                btnUpdateStatus.Visible = false;
                btnShowSummary.Visible = false; // "Restoration Tracker" might be admin-only too since it involves duration analysis
            }

            dgvRecords.DataBindingComplete += dgvRecords_DataBindingComplete;
        }

        private void dgvRecords_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                var colId = dgvRecords.Columns["ReportID"];
                if (colId != null) colId.Width = 60;

                var colDesc = dgvRecords.Columns["Description"];
                if (colDesc != null) colDesc.Visible = false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Format error: {ex.Message}");
            }
        }

        private void LoadData()
        {
            if (dgvRecords == null) return;
            try
            {

                _allReports = _outageService.GetAllReports();
                dgvRecords.DataSource = null;
                dgvRecords.DataSource = _allReports;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading records: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                dgvRecords.DataSource = _allReports;
            }
            else
            {
                var filtered = _allReports.Where(r => 
                    r.Location.ToLower().Contains(filter) || 
                    r.Status.ToLower().Contains(filter) ||
                    r.OutageType.ToLower().Contains(filter)).ToList();
                dgvRecords.DataSource = filtered;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count > 0)
            {
                // Confirmation dialog (UX Strategy Requirement)
                var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    object val = dgvRecords.SelectedRows[0].Cells["ReportID"].Value;
                    if (val is int id)
                    {
                        if (_outageService.DeleteReport(id))
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            var form = new RestorationTrackingForm();
            form.ShowDialog();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count > 0)
            {
                var report = dgvRecords.SelectedRows[0].DataBoundItem as PowerOutageReport;
                if (report != null)
                {
                    var updateForm = new OutageUpdateForm(report);
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
