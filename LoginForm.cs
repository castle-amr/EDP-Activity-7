using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private UserService userService;

        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string email = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Try to authenticate user from database
                User user = userService.AuthenticateUser(email, password);

                if (user != null)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.CurrentUser = user;
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sign up functionality would be implemented here.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecoveryForm recoveryForm = new PasswordRecoveryForm();
            recoveryForm.ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ShowPasswordCheckBox_CheckedChanged(
        object sender,
        EventArgs e)
        {
        PasswordTextBox.UseSystemPasswordChar =
        !ShowPasswordCheckBox.Checked;
        }
    }
}
