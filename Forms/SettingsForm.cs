using SmartPowerOutageSystem.Services;
using System;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly string _username;
        private readonly UserService _userService = new UserService();

        public string CurrentUsername { get; private set; }

        public SettingsForm(string username)
        {
            InitializeComponent();
            _username = username;
            CurrentUsername = username;
            txtUsername.Text = _username;
            btnSave.Text = "SAVE CHANGES";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Handle Username Change first if different
            if (!newUsername.Equals(_username, StringComparison.OrdinalIgnoreCase))
            {
                if (_userService.UserExists(newUsername))
                {
                    MessageBox.Show("Username already taken. Choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_userService.UpdateUsername(_username, newUsername))
                {
                    MessageBox.Show("Could not update username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CurrentUsername = newUsername; // Update the reference for the dashboard
            }

            // 2. Handle Password Change if requested
            if (!string.IsNullOrEmpty(newPass))
            {
                if (newPass != confirmPass)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_userService.UpdatePassword(CurrentUsername, newPass))
                {
                    MessageBox.Show("Could not update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
