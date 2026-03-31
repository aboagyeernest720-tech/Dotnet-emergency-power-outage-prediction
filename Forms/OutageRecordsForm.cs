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
            SetupManagerContextMenu();

            if (_role == "User")
            {
                btnDelete.Visible = false;
                btnUpdateStatus.Visible = false;
                btnShowSummary.Visible = false; 
            }
            else if (_role == "Dispatcher")
            {
                btnDelete.Visible = false;
            }
            else if (_role == "Technician")
            {
                btnDelete.Visible = false;
                btnShowSummary.Visible = false;
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
                    object? val = dgvRecords.SelectedRows[0].Cells["ReportID"].Value;
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

        private void SetupManagerContextMenu()
        {
            if (_role != "Manager") return;

            var ctx = new ContextMenuStrip();
            var assignItem = new ToolStripMenuItem("Assign Technician");
            assignItem.Click += AssignTechnician_Click;
            
            var minorItem = new ToolStripMenuItem("Mark as Minor Issue");
            minorItem.Click += (s, e) => ClassifyIssue("Minor");

            var majorItem = new ToolStripMenuItem("Mark as Major Issue");
            majorItem.Click += (s, e) => ClassifyIssue("Major");

            ctx.Items.Add(assignItem);
            ctx.Items.Add(new ToolStripSeparator());
            ctx.Items.Add(minorItem);
            ctx.Items.Add(majorItem);

            dgvRecords.ContextMenuStrip = ctx;
        }

        private void AssignTechnician_Click(object? sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0) return;
            var report = dgvRecords.SelectedRows[0].DataBoundItem as PowerOutageReport;
            if (report == null) return;

            var userService = new UserService();
            var techs = userService.GetUsersByRole("Technician");

            if (techs.Count == 0)
            {
                MessageBox.Show("No technicians available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Simple popup with combobox
            using var form = new Form { Text = "Assign Technician", Size = new System.Drawing.Size(300, 150), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false };
            var lbl = new Label { Text = "Select Technician:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            var cb = new ComboBox { Location = new System.Drawing.Point(10, 30), Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };
            cb.Items.AddRange(techs.ToArray());
            if (cb.Items.Count > 0) cb.SelectedIndex = 0;
            
            var btnOk = new Button { Text = "Assign", Location = new System.Drawing.Point(10, 70), DialogResult = DialogResult.OK };
            form.Controls.AddRange(new Control[] { lbl, cb, btnOk });
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                string selected = cb.SelectedItem.ToString()!;
                if (_outageService.AssignTechnician(report.ReportID, selected))
                {
                    MessageBox.Show($"Report assigned to {selected}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void ClassifyIssue(string severity)
        {
            if (dgvRecords.SelectedRows.Count == 0) return;
            var report = dgvRecords.SelectedRows[0].DataBoundItem as PowerOutageReport;
            if (report == null) return;

            if (_outageService.UpdateSeverity(report.ReportID, severity))
            {
                MessageBox.Show($"Report classified as {severity}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }
    }
}
