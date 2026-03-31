using System;
using System.Windows.Forms;
using SmartPowerOutageSystem.Models;
using SmartPowerOutageSystem.Services;

namespace SmartPowerOutageSystem.Forms
{
    public partial class PlannedOperationsForm : Form
    {
        private OperationService _operationService;
        private LocationService _locationService;
        private string _role;
        private string _username;

        public PlannedOperationsForm(string role, string username)
        {
            InitializeComponent();
            _operationService = new OperationService();
            _locationService = new LocationService();
            _role = role;
            _username = username;

            LoadLocations();
            LoadOperations();

            if (_role != "Administrator")
            {
                // Users can only view
                txtTitle.Enabled = false;
                txtDescription.Enabled = false;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                cmbLocation.Enabled = false;
                btnSave.Visible = false;
                btnDelete.Visible = false;
                dgvOperations.Visible = false;
                panelInput.Location = new System.Drawing.Point(30, 80);
                lblHeader.Text = "Official Notification Details";
                this.Text = "Notification";

                // Show data from the latest notification if it exists
                string userLocation = (new Services.UserService()).GetUserLocation(_username);
                var latestOp = _operationService.GetLatestOperationForUser(userLocation);

                if (latestOp != null)
                {
                    txtTitle.Text = latestOp.Title;
                    txtDescription.Text = latestOp.Description;
                    
                    // Hide original controls
                    dtpStart.Visible = false;
                    dtpEnd.Visible = false;
                    cmbLocation.Visible = false;
                    lblStart.Visible = false;
                    lblEnd.Visible = false;
                    lblLocation.Visible = false;

                    // Helper to get day suffix (1st, 2nd, 3rd, etc)
                    Func<int, string> getSuffix = (day) => {
                        if (day >= 11 && day <= 13) return "th";
                        switch (day % 10) {
                            case 1: return "st";
                            case 2: return "nd";
                            case 3: return "rd";
                            default: return "th";
                        }
                    };

                    string startFormatted = $"{latestOp.StartDate.Day}{getSuffix(latestOp.StartDate.Day)} {latestOp.StartDate:MMMM, yyyy}";
                    string startTimeOnly = $"{latestOp.StartDate:h:mm tt} - {latestOp.StartDate:dddd}";
                    string endTimeOnly = $"{latestOp.EndDate:h:mm tt} - {latestOp.EndDate:dddd}";

                    // Create stylish display labels with a Card Background
                    Panel pnlCard = new Panel {
                        BackColor = Color.White,
                        Location = new Point(440, 10),
                        Size = new Size(420, 240),
                        BorderStyle = BorderStyle.None
                    };

                    // Header for the card
                    Label lblScheduleHeader = new Label {
                        Text = "⚡ Schedule Details",
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(52, 152, 219),
                        Location = new Point(15, 15),
                        AutoSize = true
                    };
                    pnlCard.Controls.Add(lblScheduleHeader);

                    int startY = 60;
                    int spacingY = 40;

                    // Helper to add label pairs
                    Action<string, string, int, Color> addRow = (label, value, y, valColor) => {
                        Label lbl = new Label { 
                            Text = label, 
                            Location = new Point(15, y), 
                            AutoSize = true, 
                            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                            ForeColor = Color.Gray 
                        };
                        Label val = new Label { 
                            Text = value, 
                            Location = new Point(110, y - 2), 
                            AutoSize = true, 
                            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                            ForeColor = valColor 
                        };
                        pnlCard.Controls.Add(lbl);
                        pnlCard.Controls.Add(val);
                    };

                    addRow("Date:", startFormatted, startY, Color.Black);
                    addRow("Start:", startTimeOnly, startY + spacingY, Color.FromArgb(46, 204, 113));
                    addRow("End:", endTimeOnly, startY + (spacingY * 2), Color.FromArgb(231, 76, 60));
                    addRow("Location:", latestOp.Location, startY + (spacingY * 3), Color.FromArgb(52, 152, 219));

                    panelInput.Controls.Add(pnlCard);

                    // Update left side description for better contrast
                    txtDescription.BackColor = Color.FromArgb(248, 249, 250);
                    txtDescription.ForeColor = Color.FromArgb(33, 37, 41);
                    txtDescription.Padding = new Padding(10);
                    txtTitle.BackColor = Color.FromArgb(248, 249, 250);
                    txtTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);

                    // Add a nice orange info banner at the top of the details window
                    Panel pnlInfo = new Panel();
                    pnlInfo.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
                    pnlInfo.BorderStyle = BorderStyle.FixedSingle;
                    pnlInfo.Size = new System.Drawing.Size(900, 60);
                    pnlInfo.Location = new System.Drawing.Point(30, 70);
                    
                    Label lblInfo = new Label();
                    lblInfo.Text = $"🔔 Official Message from ECG: {latestOp.Title}";
                    lblInfo.AutoSize = true;
                    lblInfo.Location = new System.Drawing.Point(15, 15);
                    lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    lblInfo.ForeColor = System.Drawing.Color.FromArgb(230, 81, 0);
                    
                    pnlInfo.Controls.Add(lblInfo);
                    this.Controls.Add(pnlInfo);
                    
                    // Push the inputs down to make room for the banner
                    panelInput.Location = new System.Drawing.Point(30, 140);
                    lblHeader.Text = "Notification Details";
                }
                else
                {
                    // Hide everything if no notification
                    panelInput.Visible = false;
                    
                    Label lblEmpty = new Label();
                    lblEmpty.Text = "You have no new notifications from the Admin.";
                    lblEmpty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
                    lblEmpty.ForeColor = System.Drawing.Color.Gray;
                    lblEmpty.AutoSize = true;
                    lblEmpty.Location = new System.Drawing.Point(30, 80);
                    this.Controls.Add(lblEmpty);

                    // Re-add a back button for the empty state
                    Button btnBackEmpty = new Button();
                    btnBackEmpty.Text = "Back";
                    btnBackEmpty.Size = new System.Drawing.Size(120, 40);
                    btnBackEmpty.Location = new System.Drawing.Point(30, 130);
                    btnBackEmpty.BackColor = System.Drawing.Color.FromArgb(100, 110, 120);
                    btnBackEmpty.ForeColor = System.Drawing.Color.White;
                    btnBackEmpty.FlatStyle = FlatStyle.Flat;
                    btnBackEmpty.Click += (s, ev) => this.Close();
                    this.Controls.Add(btnBackEmpty);
                }
            }
            else
            {
                lblHeader.Text = "Manage Planned Operations";
            }
        }

        private void LoadLocations()
        {
            var dt = _locationService.GetAllLocations();
            cmbLocation.Items.Clear();
            cmbLocation.Items.Add("All Regions");
            foreach (System.Data.DataRow row in dt.Rows)
            {
                cmbLocation.Items.Add(row["LocationName"]?.ToString() ?? "Unknown");
            }
            if (cmbLocation.Items.Count > 0)
                cmbLocation.SelectedIndex = 0;
        }

        private void LoadOperations()
        {
            dgvOperations.DataSource = _operationService.GetAllOperations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var op = new PlannedOperation
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value,
                Location = cmbLocation.SelectedItem?.ToString() ?? "All Regions",
                CreatedBy = _username
            };

            if (_operationService.AddPlannedOperation(op))
            {
                MessageBox.Show("Planned operation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadOperations();
            }
            else
            {
                MessageBox.Show("Failed to save planned operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOperations.SelectedRows.Count > 0)
            {
                var cellValue = dgvOperations.SelectedRows[0].Cells["OperationID"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int id = Convert.ToInt32(cellValue);
                    
                    var confirm = MessageBox.Show("Are you sure you want to delete this operation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        if (_operationService.DeleteOperation(id))
                        {
                            MessageBox.Show("Operation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOperations();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an operation to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddHours(2);
            if (cmbLocation.Items.Count > 0)
                cmbLocation.SelectedIndex = 0;
        }
    }
}
