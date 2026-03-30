using SmartPowerOutageSystem.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class UserManagementForm : Form
    {
        private readonly UserService _userService = new UserService();

        public UserManagementForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            dgvUsers.DataSource = _userService.GetAllUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userService.SaveUser(username, password, role))
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Error saving user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username)) return;

            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The primary admin account cannot be deleted.", "Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to delete user '{username}'?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                if (_userService.DeleteUser(username))
                {
                    MessageBox.Show("User deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadUserData();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            txtUsername.ReadOnly = false;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
                txtUsername.ReadOnly = true; // Don't allow renaming username in edit mode
            }
        }
    }
}
