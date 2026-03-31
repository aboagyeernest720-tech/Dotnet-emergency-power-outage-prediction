using SmartPowerOutageSystem.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class LocationManagementForm : Form
    {
        private readonly LocationService _locationService = new LocationService();

        public LocationManagementForm()
        {
            InitializeComponent();
            LoadLocationData();
        }

        private void LoadLocationData()
        {
            dgvLocations.DataSource = _locationService.GetAllLocations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtLocationName.Text.Trim();
            string region = txtRegion.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(region))
            {
                MessageBox.Show("Please fill all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_locationService.SaveLocation(name, region))
            {
                MessageBox.Show("Location added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLocationName.Clear();
                txtRegion.Clear();
                LoadLocationData();
            }
            else
            {
                MessageBox.Show("Error saving location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLocations.CurrentRow != null)
            {
                var idVal = dgvLocations.CurrentRow.Cells["LocationID"].Value;
                var nameVal = dgvLocations.CurrentRow.Cells["LocationName"].Value;
                
                if (idVal != null && idVal != DBNull.Value)
                {
                    int id = Convert.ToInt32(idVal);
                    string name = nameVal?.ToString() ?? "Unknown Location";

                    var confirm = MessageBox.Show($"Are you sure you want to delete location '{name}'?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (confirm == DialogResult.OK)
                    {
                        if (_locationService.DeleteLocation(id))
                        {
                            MessageBox.Show("Location deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLocationData();
                        }
                    }
                }
            }
        }
    }
}
