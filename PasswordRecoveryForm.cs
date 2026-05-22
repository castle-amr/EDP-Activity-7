using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PasswordRecoveryForm : Form
    {
        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void SendResetLinkButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Password reset link has been sent to {email}.", "Reset Link Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BackLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
