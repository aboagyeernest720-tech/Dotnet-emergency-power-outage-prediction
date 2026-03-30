using System;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    public partial class AboutSystemForm : Form
    {
        public AboutSystemForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
