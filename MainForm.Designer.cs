namespace WindowsFormsApp1
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.UserManagementButton = new System.Windows.Forms.Button();
            this.ReportGeneratorButton = new System.Windows.Forms.Button();
            this.CheckOrdersButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SidebarPanel.SuspendLayout();
            this.SuspendLayout();

            // SidebarPanel
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.SidebarPanel.Controls.Add(this.LogoutButton);
            this.SidebarPanel.Controls.Add(this.AboutButton);
            this.SidebarPanel.Controls.Add(this.UserManagementButton);
            this.SidebarPanel.Controls.Add(this.ReportGeneratorButton);
            this.SidebarPanel.Controls.Add(this.CheckOrdersButton);
            this.SidebarPanel.Controls.Add(this.DashboardButton);
            this.SidebarPanel.Controls.Add(this.LogoLabel);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(150, 600);
            this.SidebarPanel.TabIndex = 0;

            // LogoLabel
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(15, 20);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(120, 25);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "E-ComTrack";

            // DashboardButton
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(41, 57, 74);
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Location = new System.Drawing.Point(10, 70);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(130, 40);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);

            // CheckOrdersButton
            this.CheckOrdersButton.BackColor = System.Drawing.Color.FromArgb(41, 57, 74);
            this.CheckOrdersButton.FlatAppearance.BorderSize = 0;
            this.CheckOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOrdersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckOrdersButton.ForeColor = System.Drawing.Color.White;
            this.CheckOrdersButton.Location = new System.Drawing.Point(10, 120);
            this.CheckOrdersButton.Name = "CheckOrdersButton";
            this.CheckOrdersButton.Size = new System.Drawing.Size(130, 40);
            this.CheckOrdersButton.TabIndex = 2;
            this.CheckOrdersButton.Text = "Check Orders";
            this.CheckOrdersButton.UseVisualStyleBackColor = false;
            this.CheckOrdersButton.Click += new System.EventHandler(this.CheckOrdersButton_Click);

            // ReportGeneratorButton
            this.ReportGeneratorButton.BackColor = System.Drawing.Color.FromArgb(41, 57, 74);
            this.ReportGeneratorButton.FlatAppearance.BorderSize = 0;
            this.ReportGeneratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportGeneratorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportGeneratorButton.ForeColor = System.Drawing.Color.White;
            this.ReportGeneratorButton.Location = new System.Drawing.Point(10, 170);
            this.ReportGeneratorButton.Name = "ReportGeneratorButton";
            this.ReportGeneratorButton.Size = new System.Drawing.Size(130, 40);
            this.ReportGeneratorButton.TabIndex = 3;
            this.ReportGeneratorButton.Text = "Report Generator";
            this.ReportGeneratorButton.UseVisualStyleBackColor = false;
            this.ReportGeneratorButton.Click += new System.EventHandler(this.ReportGeneratorButton_Click);

            // UserManagementButton
            this.UserManagementButton.BackColor = System.Drawing.Color.FromArgb(41, 57, 74);
            this.UserManagementButton.FlatAppearance.BorderSize = 0;
            this.UserManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagementButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserManagementButton.ForeColor = System.Drawing.Color.White;
            this.UserManagementButton.Location = new System.Drawing.Point(10, 220);
            this.UserManagementButton.Name = "UserManagementButton";
            this.UserManagementButton.Size = new System.Drawing.Size(130, 40);
            this.UserManagementButton.TabIndex = 4;
            this.UserManagementButton.Text = "User Management";
            this.UserManagementButton.UseVisualStyleBackColor = false;
            this.UserManagementButton.Click += new System.EventHandler(this.UserManagementButton_Click);

            // AboutButton
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(41, 57, 74);
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(10, 270);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(130, 40);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);

            // LogoutButton
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(10, 550);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(130, 40);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);

            // ContentPanel
            this.ContentPanel.BackColor = System.Drawing.Color.White;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(150, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(650, 600);
            this.ContentPanel.TabIndex = 1;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-ComTrack - Order Tracking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button UserManagementButton;
        private System.Windows.Forms.Button ReportGeneratorButton;
        private System.Windows.Forms.Button CheckOrdersButton;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel ContentPanel;
    }
}
