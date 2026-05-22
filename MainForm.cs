using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public User CurrentUser { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load dashboard by default
            ShowDashboard();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void CheckOrdersButton_Click(object sender, EventArgs e)
        {
            ShowCheckOrders();
        }

        private void ReportGeneratorButton_Click(object sender, EventArgs e)
        {
            ShowReportGenerator();
        }

        private void UserManagementButton_Click(object sender, EventArgs e)
        {
            ShowUserManagement();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void ShowDashboard()
        {
            ContentPanel.Controls.Clear();
            DashboardPanel dashboard = new DashboardPanel();
            dashboard.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(dashboard);
        }

        private void ShowCheckOrders()
        {
            ContentPanel.Controls.Clear();
            CheckOrdersPanel checkOrders = new CheckOrdersPanel();
            checkOrders.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(checkOrders);
        }

        private void ShowReportGenerator()
        {
            ContentPanel.Controls.Clear();
            ReportGeneratorPanel reportGen = new ReportGeneratorPanel();
            reportGen.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(reportGen);
        }

        private void ShowUserManagement()
        {
            ContentPanel.Controls.Clear();
            UserManagementPanel userManagement = new UserManagementPanel();
            userManagement.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(userManagement);
        }

        private void ShowAbout()
        {
            ContentPanel.Controls.Clear();
            AboutPanel about = new AboutPanel();
            about.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(about);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
