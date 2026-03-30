using System.Drawing;
using System.Windows.Forms;

namespace SmartPowerOutageSystem.Forms
{
    partial class LocationManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            dgvLocations = new DataGridView();
            panelForm = new Panel();
            btnDelete = new Button();
            btnSave = new Button();
            txtRegion = new TextBox();
            lblRegion = new Label();
            txtLocationName = new TextBox();
            lblLocationName = new Label();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocations).BeginInit();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(121, 85, 72);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(362, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "LOCATION MANAGEMENT";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(dgvLocations);
            panelContent.Controls.Add(panelForm);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 80);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1000, 620);
            panelContent.TabIndex = 1;
            // 
            // dgvLocations
            // 
            dgvLocations.AllowUserToAddRows = false;
            dgvLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocations.BackgroundColor = Color.White;
            dgvLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocations.Dock = DockStyle.Fill;
            dgvLocations.Location = new Point(370, 20);
            dgvLocations.MultiSelect = false;
            dgvLocations.Name = "dgvLocations";
            dgvLocations.ReadOnly = true;
            dgvLocations.RowHeadersVisible = false;
            dgvLocations.RowHeadersWidth = 51;
            dgvLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocations.Size = new Size(610, 580);
            dgvLocations.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(txtRegion);
            panelForm.Controls.Add(lblRegion);
            panelForm.Controls.Add(txtLocationName);
            panelForm.Controls.Add(lblLocationName);
            panelForm.Dock = DockStyle.Left;
            panelForm.Location = new Point(20, 20);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(350, 580);
            panelForm.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(20, 270);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(310, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Location";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(121, 85, 72);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(310, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "Add Location";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtRegion
            // 
            txtRegion.Font = new Font("Segoe UI", 11F);
            txtRegion.Location = new Point(20, 150);
            txtRegion.Name = "txtRegion";
            txtRegion.PlaceholderText = "E.g. Ashanti, Greater Accra...";
            txtRegion.Size = new Size(310, 32);
            txtRegion.TabIndex = 3;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRegion.Location = new Point(20, 125);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(64, 23);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Region";
            // 
            // txtLocationName
            // 
            txtLocationName.Font = new Font("Segoe UI", 11F);
            txtLocationName.Location = new Point(20, 70);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.PlaceholderText = "E.g. Adum, East Legon...";
            txtLocationName.Size = new Size(310, 32);
            txtLocationName.TabIndex = 1;
            // 
            // lblLocationName
            // 
            lblLocationName.AutoSize = true;
            lblLocationName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLocationName.Location = new Point(20, 45);
            lblLocationName.Name = "lblLocationName";
            lblLocationName.Size = new Size(126, 23);
            lblLocationName.TabIndex = 0;
            lblLocationName.Text = "Location Name";
            // 
            // LocationManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "LocationManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Location Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLocations).EndInit();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private Panel panelForm;
        private Label lblLocationName;
        private TextBox txtLocationName;
        private Label lblRegion;
        private TextBox txtRegion;
        private Button btnSave;
        private Button btnDelete;
        private DataGridView dgvLocations;
    }
}
