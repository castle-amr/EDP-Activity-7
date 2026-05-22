namespace WindowsFormsApp1
{
    partial class ReportGeneratorPanel
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
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.OrderSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();


            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Generate Report";

            // OrderSummaryLabel
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OrderSummaryLabel.Location = new System.Drawing.Point(20, 80);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(103, 19);
            this.OrderSummaryLabel.TabIndex = 1;
            this.OrderSummaryLabel.Text = "Order Summary:";

            // OrderSummaryComboBox
            this.OrderSummaryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OrderSummaryComboBox.FormattingEnabled = true;
            this.OrderSummaryComboBox.Location = new System.Drawing.Point(150, 75);
            this.OrderSummaryComboBox.Name = "OrderSummaryComboBox";
            this.OrderSummaryComboBox.Size = new System.Drawing.Size(300, 25);
            this.OrderSummaryComboBox.TabIndex = 2;
            this.OrderSummaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // GenerateButton
            this.GenerateButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(200, 150);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(250, 45);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);

            // ReportGeneratorPanel
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OrderSummaryComboBox);
            this.Controls.Add(this.OrderSummaryLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "ReportGeneratorPanel";
            this.Size = new System.Drawing.Size(650, 600);
            this.Load += new System.EventHandler(this.ReportGeneratorPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.ComboBox OrderSummaryComboBox;
        private System.Windows.Forms.Button GenerateButton;
    }
}
