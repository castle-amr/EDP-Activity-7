namespace WindowsFormsApp1
{
    partial class PasswordRecoveryForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SendResetLinkButton = new System.Windows.Forms.Button();
            this.BackLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(130, 60);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(240, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Password Recovery";

            // EmailLabel
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmailLabel.Location = new System.Drawing.Point(130, 130);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";

            // EmailTextBox
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmailTextBox.Location = new System.Drawing.Point(130, 155);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(240, 25);
            this.EmailTextBox.TabIndex = 2;

            // SendResetLinkButton
            this.SendResetLinkButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.SendResetLinkButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SendResetLinkButton.ForeColor = System.Drawing.Color.White;
            this.SendResetLinkButton.Location = new System.Drawing.Point(130, 210);
            this.SendResetLinkButton.Name = "SendResetLinkButton";
            this.SendResetLinkButton.Size = new System.Drawing.Size(240, 35);
            this.SendResetLinkButton.TabIndex = 3;
            this.SendResetLinkButton.Text = "Send Reset Link";
            this.SendResetLinkButton.UseVisualStyleBackColor = false;
            this.SendResetLinkButton.Click += new System.EventHandler(this.SendResetLinkButton_Click);

            // BackLoginButton
            this.BackLoginButton.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.BackLoginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BackLoginButton.ForeColor = System.Drawing.Color.White;
            this.BackLoginButton.Location = new System.Drawing.Point(130, 260);
            this.BackLoginButton.Name = "BackLoginButton";
            this.BackLoginButton.Size = new System.Drawing.Size(240, 35);
            this.BackLoginButton.TabIndex = 4;
            this.BackLoginButton.Text = "Back to Login";
            this.BackLoginButton.UseVisualStyleBackColor = false;
            this.BackLoginButton.Click += new System.EventHandler(this.BackLoginButton_Click);

            // PasswordRecoveryForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.BackLoginButton);
            this.Controls.Add(this.SendResetLinkButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "PasswordRecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-ComTrack - Password Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button SendResetLinkButton;
        private System.Windows.Forms.Button BackLoginButton;
    }
}
