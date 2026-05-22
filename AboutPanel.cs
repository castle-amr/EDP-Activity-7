using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AboutPanel : UserControl
    {
        public AboutPanel()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string message = MessageTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Thank you for your feedback, {name}!\nWe'll get back to you at {email}.", "Feedback Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear form
            NameTextBox.Clear();
            EmailTextBox.Clear();
            MessageTextBox.Clear();
        }
    }
}
