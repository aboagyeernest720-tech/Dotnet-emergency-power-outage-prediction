using System;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class SignupForm : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly LocationService _locationService = new LocationService();
        public string? NewUsername { get; private set; }
        public string? NewPassword { get; private set; }

        public SignupForm()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void LoadLocations()
        {
            int userCount = _userService.GetUserCount();
            
            // Always show labels/controls
            lblLocation.Visible = true;
            cmbLocation.Visible = true;
            cmbLocation.Items.Clear();

            if (userCount == 0)
            {
                // First user is Admin - Force HQ
                cmbLocation.Items.Add("Headquarters");
                cmbLocation.SelectedIndex = 0;
                // We keep it enabled so they can see it, but it's their only choice
                cmbLocation.Enabled = false; 
            }
            else
            {
                // Subsequent users - Standard flow
                cmbLocation.Enabled = true;
                cmbLocation.Items.Add("Choose your location");
                
                var dt = _locationService.GetAllLocations();
                foreach (System.Data.DataRow row in dt.Rows)
                {
                    cmbLocation.Items.Add(row["LocationName"]?.ToString() ?? "Unknown");
                }
                
                cmbLocation.SelectedIndex = 0;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirm = txtConfirmPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirm)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password.Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_userService.UserExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userCount = _userService.GetUserCount();
                string userLocation = "Unknown";

                if (userCount == 0)
                {
                    // First user is always HQ Admin
                    userLocation = "Headquarters";
                }
                else
                {
                    // Subsequent users must pick a location
                    if (cmbLocation.SelectedIndex <= 0) // Placeholder is at 0
                    {
                        MessageBox.Show("Please select a valid location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    userLocation = cmbLocation.SelectedItem?.ToString() ?? "Unknown";
                }

                // Decide role based on count
                string assignedRole = userCount == 0 ? "Administrator" : "User";

                if (_userService.SaveUser(username, password, assignedRole, userLocation))
                {
                    NewUsername = username;
                    NewPassword = password;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not create account. The username might already be in use.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
