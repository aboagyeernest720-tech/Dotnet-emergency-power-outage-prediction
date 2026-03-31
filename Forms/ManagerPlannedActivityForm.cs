using SmartPowerOutageSystem.Data;
using SmartPowerOutageSystem.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public class ManagerPlannedActivityForm : Form
    {
        private ComboBox cbLocation;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;
        private TextBox txtMessage;
        private Button btnSend;

        public ManagerPlannedActivityForm()
        {
            InitializeComponent();
            LoadLocations();
        }

        private void InitializeComponent()
        {
            this.Text = "Send Planned Activity Notification";
            this.Size = new Size(500, 450);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            var lblLoc = new Label { Text = "Target Location:", Location = new Point(20, 20), AutoSize = true };
            cbLocation = new ComboBox { Location = new Point(20, 45), Width = 440, DropDownStyle = ComboBoxStyle.DropDownList };

            var lblDate = new Label { Text = "Planned Date:", Location = new Point(20, 85), AutoSize = true };
            dtpDate = new DateTimePicker { Location = new Point(20, 110), Width = 200, Format = DateTimePickerFormat.Short };

            var lblTime = new Label { Text = "Planned Time:", Location = new Point(260, 85), AutoSize = true };
            dtpTime = new DateTimePicker { Location = new Point(260, 110), Width = 200, Format = DateTimePickerFormat.Time, ShowUpDown = true };

            var lblMsg = new Label { Text = "Notification Message:", Location = new Point(20, 150), AutoSize = true };
            txtMessage = new TextBox { Location = new Point(20, 175), Width = 440, Height = 100, Multiline = true };
            txtMessage.Text = "Please be informed of a planned activity taking place on {0} at {1}. Thank you.";

            btnSend = new Button 
            { 
                Text = "Send Notification", 
                Location = new Point(20, 290), 
                Width = 440, 
                Height = 45,
                BackColor = Color.FromArgb(17, 33, 51),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 11)
            };
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.Click += BtnSend_Click;

            this.Controls.AddRange(new Control[] { lblLoc, cbLocation, lblDate, dtpDate, lblTime, dtpTime, lblMsg, txtMessage, btnSend });

            // Auto-update message
            dtpDate.ValueChanged += UpdateTemplate;
            dtpTime.ValueChanged += UpdateTemplate;
        }

        private void UpdateTemplate(object? sender, EventArgs e)
        {
            txtMessage.Text = $"Please be informed of a planned power system activity taking place on {dtpDate.Value:dd MMM yyyy} at {dtpTime.Value:hh:mm tt}. Thank you.";
        }

        private void LoadLocations()
        {
            try
            {
                using var connection = DatabaseHelper.GetConnection();
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT LocationName FROM Locations ORDER BY LocationName";
                using var reader = cmd.ExecuteReader();
                cbLocation.Items.Add("All"); // Allow sending to all users globally
                while (reader.Read())
                {
                    cbLocation.Items.Add(reader.GetString(0));
                }
                if (cbLocation.Items.Count > 0) cbLocation.SelectedIndex = 0;
            }
            catch (Exception)
            {
                // Fallback
                cbLocation.Items.Add("All");
                cbLocation.SelectedIndex = 0;
            }
        }

        private void BtnSend_Click(object? sender, EventArgs e)
        {
            if (cbLocation.SelectedItem == null || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loc = cbLocation.SelectedItem.ToString()!;
            string msg = txtMessage.Text.Trim();

            var service = new NotificationService();
            if (service.SendNotificationToLocation(loc, msg))
            {
                MessageBox.Show($"Notification successfully sent to users in {loc}.", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not send notifications. Ensure there are users in the selected location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
