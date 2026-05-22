namespace WindowsFormsApp1
{
    partial class CheckOrdersPanel
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
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(146, 32);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Check Orders";

            // OrderIDLabel
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OrderIDLabel.Location = new System.Drawing.Point(20, 70);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(66, 19);
            this.OrderIDLabel.TabIndex = 1;
            this.OrderIDLabel.Text = "Order ID:";

            // OrderIDTextBox
            this.OrderIDTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OrderIDTextBox.Location = new System.Drawing.Point(100, 65);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(250, 25);
            this.OrderIDTextBox.TabIndex = 2;

            // SearchButton
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(370, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 25);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);

            // ClearButton
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(460, 65);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(80, 25);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);

            // ResultsDataGridView
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Location = new System.Drawing.Point(20, 120);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.Size = new System.Drawing.Size(600, 450);
            this.ResultsDataGridView.TabIndex = 5;

            // Setup columns
            this.ResultsDataGridView.Columns.Add("OrderID", "Order ID");
            this.ResultsDataGridView.Columns.Add("Customer", "Customer");
            this.ResultsDataGridView.Columns.Add("Amount", "Amount");
            this.ResultsDataGridView.Columns.Add("Status", "Status");
            this.ResultsDataGridView.Columns.Add("Details", "Details");

            // CheckOrdersPanel
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.OrderIDLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CheckOrdersPanel";
            this.Size = new System.Drawing.Size(650, 600);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
    }
}
