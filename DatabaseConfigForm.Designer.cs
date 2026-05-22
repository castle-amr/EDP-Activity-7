namespace WindowsFormsApp1
{
    partial class DatabaseConfigForm
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
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(265, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Database Configuration";

            // ServerLabel
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServerLabel.Location = new System.Drawing.Point(20, 70);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(51, 19);
            this.ServerLabel.TabIndex = 1;
            this.ServerLabel.Text = "Server:";

            // ServerTextBox
            this.ServerTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServerTextBox.Location = new System.Drawing.Point(120, 65);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(250, 25);
            this.ServerTextBox.TabIndex = 2;

            // DatabaseLabel
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DatabaseLabel.Location = new System.Drawing.Point(20, 110);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(69, 19);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database:";

            // DatabaseTextBox
            this.DatabaseTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DatabaseTextBox.Location = new System.Drawing.Point(120, 105);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(250, 25);
            this.DatabaseTextBox.TabIndex = 4;

            // UserLabel
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserLabel.Location = new System.Drawing.Point(20, 150);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(35, 19);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "User:";

            // UserTextBox
            this.UserTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UserTextBox.Location = new System.Drawing.Point(120, 145);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(250, 25);
            this.UserTextBox.TabIndex = 6;

            // PasswordLabel
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PasswordLabel.Location = new System.Drawing.Point(20, 190);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(66, 19);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password:";

            // PasswordTextBox
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PasswordTextBox.Location = new System.Drawing.Point(120, 185);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(250, 25);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;

            // PortLabel
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortLabel.Location = new System.Drawing.Point(20, 230);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(34, 19);
            this.PortLabel.TabIndex = 9;
            this.PortLabel.Text = "Port:";

            // PortTextBox
            this.PortTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PortTextBox.Location = new System.Drawing.Point(120, 225);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(250, 25);
            this.PortTextBox.TabIndex = 10;

            // TestConnectionButton
            this.TestConnectionButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.TestConnectionButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TestConnectionButton.ForeColor = System.Drawing.Color.White;
            this.TestConnectionButton.Location = new System.Drawing.Point(20, 280);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(150, 35);
            this.TestConnectionButton.TabIndex = 11;
            this.TestConnectionButton.Text = "Test Connection";
            this.TestConnectionButton.UseVisualStyleBackColor = false;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);

            // SaveButton
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(220, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 35);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);

            // CancelButton
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(295, 280);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 35);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);

            // DatabaseConfigForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TestConnectionButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DatabaseConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-ComTrack - Database Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
