namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(170, 60);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(210, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "E-ComTrack";

            // UsernameLabel
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UsernameLabel.Location = new System.Drawing.Point(160, 150);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";

            // PasswordLabel
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PasswordLabel.Location = new System.Drawing.Point(160, 220);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(66, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";

            // UsernameTextBox
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UsernameTextBox.Location = new System.Drawing.Point(160, 175);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(260, 25);
            this.UsernameTextBox.TabIndex = 3;

            // PasswordTextBox
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PasswordTextBox.Location = new System.Drawing.Point(160, 245);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(260, 25);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;

            // SignInButton
            this.SignInButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.Location = new System.Drawing.Point(160, 310);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(260, 40);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);

            // SignUpLinkLabel
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Location = new System.Drawing.Point(160, 360);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(48, 15);
            this.SignUpLinkLabel.TabIndex = 6;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Sign up?";
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);

            // ForgotPasswordLinkLabel
            this.ForgotPasswordLinkLabel.AutoSize = true;
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(330, 360);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(90, 15);
            this.ForgotPasswordLinkLabel.TabIndex = 7;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Forgot password?";
            this.ForgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLinkLabel_LinkClicked);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.ForgotPasswordLinkLabel);
            this.Controls.Add(this.SignUpLinkLabel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-ComTrack - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.LinkLabel ForgotPasswordLinkLabel;
    }
}
