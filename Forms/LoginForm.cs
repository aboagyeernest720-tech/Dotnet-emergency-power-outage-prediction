using System;
using System.Windows.Forms;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_userService.Authenticate(username, password))
                {
                    string role = _userService.GetUserRole(username);
                    MessageBox.Show($"Login successful! Welcome, {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Show specialized Dashboard
                    this.Hide();
                    if (role == "Administrator")
                    {
                        var adminDashboard = new AdminDashboardForm(username);
                        adminDashboard.Show();
                    }
                    else
                    {
                        var userDashboard = new UserDashboardForm(username);
                        userDashboard.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuestLogin_Click(object sender, EventArgs e)
        {
            using (var idForm = new UserIdentificationForm())
            {
                if (idForm.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    // Pass username as 'Name (Phone)' and use User dashboard
                    var guestDashboard = new UserDashboardForm($"{idForm.UserName} ({idForm.UserPhone})");
                    guestDashboard.Show();
                }
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            using (var signupForm = new SignupForm())
            {
                if (signupForm.ShowDialog() == DialogResult.OK)
                {
                    txtUsername.Text = signupForm.NewUsername;
                    txtPassword.Text = signupForm.NewPassword;
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
