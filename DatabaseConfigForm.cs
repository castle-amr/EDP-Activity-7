using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DatabaseConfigForm : Form
    {
        private DatabaseConnection dbConnection;

        public DatabaseConfigForm()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadSettings();
        }

        private void LoadSettings()
        {
            ServerTextBox.Text = ConfigurationManager.AppSettings["DatabaseServer"] ?? "127.0.0.1";
            DatabaseTextBox.Text = ConfigurationManager.AppSettings["DatabaseName"] ?? "e-marketplace_is";
            UserTextBox.Text = ConfigurationManager.AppSettings["DatabaseUser"] ?? "root";
            PasswordTextBox.Text = ConfigurationManager.AppSettings["DatabasePassword"] ?? "";
            PortTextBox.Text = ConfigurationManager.AppSettings["DatabasePort"] ?? "3306";
        }

        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string server = ServerTextBox.Text.Trim();
                string database = DatabaseTextBox.Text.Trim();
                string user = UserTextBox.Text.Trim();
                string password = PasswordTextBox.Text;
                string port = PortTextBox.Text.Trim();

                if (!int.TryParse(port, out int portNum))
                {
                    MessageBox.Show("Port must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnection.SetConnectionString(server, database, user, password, portNum);

                if (dbConnection.TestConnection())
                {
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // In a real application, you would save these settings to a configuration file
                string server = ServerTextBox.Text.Trim();
                string database = DatabaseTextBox.Text.Trim();
                string user = UserTextBox.Text.Trim();
                string password = PasswordTextBox.Text;
                string port = PortTextBox.Text.Trim();

                if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnection.SetConnectionString(server, database, user, password, int.Parse(port));

                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
