using System;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class UserIdentificationForm : Form
    {
        public string UserName { get; private set; } = string.Empty;
        public string UserPhone { get; private set; } = string.Empty;

        public UserIdentificationForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Both name and phone number are required.", "Identification Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserName = name;
            UserPhone = phone;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
