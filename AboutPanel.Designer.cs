namespace WindowsFormsApp1
{
    partial class AboutPanel
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
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(265, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "About the Program";

            // DescriptionLabel
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 70);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(351, 19);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "E-Commerce Information System";

            // ProgramDescriptionLabel
            System.Windows.Forms.Label programDescriptionLabel = new System.Windows.Forms.Label();
            programDescriptionLabel.AutoSize = true;
            programDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            programDescriptionLabel.ForeColor = System.Drawing.Color.Gray;
            programDescriptionLabel.Location = new System.Drawing.Point(20, 95);
            programDescriptionLabel.Name = "ProgramDescriptionLabel";
            programDescriptionLabel.Size = new System.Drawing.Size(400, 38);
            programDescriptionLabel.Text = "This system manages and tracks orders efficiently.\r\nProviding real-time order status updates.";
            this.Controls.Add(programDescriptionLabel);

            // FeedbackLabel
            this.FeedbackLabel.AutoSize = true;
            this.FeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FeedbackLabel.Location = new System.Drawing.Point(20, 150);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(107, 21);
            this.FeedbackLabel.TabIndex = 2;
            this.FeedbackLabel.Text = "Send Feedback";

            // NameLabel
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NameLabel.Location = new System.Drawing.Point(50, 190);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 19);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";

            // NameTextBox
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NameTextBox.Location = new System.Drawing.Point(130, 185);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 25);
            this.NameTextBox.TabIndex = 4;

            // EmailLabel
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmailLabel.Location = new System.Drawing.Point(50, 230);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";

            // EmailTextBox
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmailTextBox.Location = new System.Drawing.Point(130, 225);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(300, 25);
            this.EmailTextBox.TabIndex = 6;

            // MessageLabel
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MessageLabel.Location = new System.Drawing.Point(50, 270);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(66, 19);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "Message";

            // MessageTextBox
            this.MessageTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MessageTextBox.Location = new System.Drawing.Point(130, 265);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(300, 80);
            this.MessageTextBox.TabIndex = 8;

            // SendButton
            this.SendButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(200, 360);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(230, 40);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Submit";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);

            // AboutPanel
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(programDescriptionLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AboutPanel";
            this.Size = new System.Drawing.Size(650, 600);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
    }
}
