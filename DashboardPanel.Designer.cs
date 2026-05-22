namespace WindowsFormsApp1
{
    partial class DashboardPanel
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
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.TotalOrdersLabel = new System.Windows.Forms.Label();
            this.RevenuePanel = new System.Windows.Forms.Panel();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.TotalRevenueLabel = new System.Windows.Forms.Label();
            this.PendingOrdersPanel = new System.Windows.Forms.Panel();
            this.PendingOrdersLabel = new System.Windows.Forms.Label();
            this.PendingOrdersValueLabel = new System.Windows.Forms.Label();
            this.RecentOrdersLabel = new System.Windows.Forms.Label();
            this.RecentOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.OrderStatusTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.RefreshOrdersButton = new System.Windows.Forms.Button();
            this.StatsPanel.SuspendLayout();
            this.OrdersPanel.SuspendLayout();
            this.RevenuePanel.SuspendLayout();
            this.PendingOrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentOrdersDataGridView)).BeginInit();
            this.SuspendLayout();

            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(20, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(84, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dashboard";

            this.StatsPanel.BackColor = System.Drawing.Color.LightGray;
            this.StatsPanel.Controls.Add(this.OrdersPanel);
            this.StatsPanel.Controls.Add(this.RevenuePanel);
            this.StatsPanel.Controls.Add(this.PendingOrdersPanel);
            this.StatsPanel.Location = new System.Drawing.Point(20, 60);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(600, 110);
            this.StatsPanel.TabIndex = 1;

            this.OrdersPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.OrdersPanel.Controls.Add(this.OrdersLabel);
            this.OrdersPanel.Controls.Add(this.TotalOrdersLabel);
            this.OrdersPanel.Location = new System.Drawing.Point(10, 10);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(170, 90);
            this.OrdersPanel.TabIndex = 0;

            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OrdersLabel.ForeColor = System.Drawing.Color.White;
            this.OrdersLabel.Location = new System.Drawing.Point(10, 10);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Text = "Total Orders";

            this.TotalOrdersLabel.AutoSize = true;
            this.TotalOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.TotalOrdersLabel.ForeColor = System.Drawing.Color.White;
            this.TotalOrdersLabel.Location = new System.Drawing.Point(10, 35);
            this.TotalOrdersLabel.Name = "TotalOrdersLabel";
            this.TotalOrdersLabel.Text = "0";

            this.RevenuePanel.BackColor = System.Drawing.Color.ForestGreen;
            this.RevenuePanel.Controls.Add(this.RevenueLabel);
            this.RevenuePanel.Controls.Add(this.TotalRevenueLabel);
            this.RevenuePanel.Location = new System.Drawing.Point(210, 10);
            this.RevenuePanel.Name = "RevenuePanel";
            this.RevenuePanel.Size = new System.Drawing.Size(170, 90);
            this.RevenuePanel.TabIndex = 1;

            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RevenueLabel.ForeColor = System.Drawing.Color.White;
            this.RevenueLabel.Location = new System.Drawing.Point(10, 10);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Text = "Total Revenue";

            this.TotalRevenueLabel.AutoSize = true;
            this.TotalRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TotalRevenueLabel.ForeColor = System.Drawing.Color.White;
            this.TotalRevenueLabel.Location = new System.Drawing.Point(10, 35);
            this.TotalRevenueLabel.Name = "TotalRevenueLabel";
            this.TotalRevenueLabel.Text = "P0.00";

            this.PendingOrdersPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.PendingOrdersPanel.Location = new System.Drawing.Point(410, 10);
            this.PendingOrdersPanel.Name = "PendingOrdersPanel";
            this.PendingOrdersPanel.Size = new System.Drawing.Size(170, 90);
            this.PendingOrdersPanel.TabIndex = 2;
            this.PendingOrdersPanel.Controls.Add(this.PendingOrdersLabel);
            this.PendingOrdersPanel.Controls.Add(this.PendingOrdersValueLabel);

            this.PendingOrdersLabel.AutoSize = true;
            this.PendingOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PendingOrdersLabel.ForeColor = System.Drawing.Color.White;
            this.PendingOrdersLabel.Location = new System.Drawing.Point(10, 10);
            this.PendingOrdersLabel.Name = "PendingOrdersLabel";
            this.PendingOrdersLabel.Text = "Pending Orders";

            this.PendingOrdersValueLabel.AutoSize = true;
            this.PendingOrdersValueLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.PendingOrdersValueLabel.ForeColor = System.Drawing.Color.White;
            this.PendingOrdersValueLabel.Location = new System.Drawing.Point(10, 35);
            this.PendingOrdersValueLabel.Name = "PendingOrdersValueLabel";
            this.PendingOrdersValueLabel.Text = "0%";

            this.RecentOrdersLabel.AutoSize = true;
            this.RecentOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RecentOrdersLabel.Location = new System.Drawing.Point(20, 190);
            this.RecentOrdersLabel.Name = "RecentOrdersLabel";
            this.RecentOrdersLabel.Text = "Recent Orders";
            this.RecentOrdersLabel.TabIndex = 2;

            this.RecentOrdersDataGridView.AllowUserToAddRows = false;
            this.RecentOrdersDataGridView.AllowUserToDeleteRows = false;
            this.RecentOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecentOrdersDataGridView.Location = new System.Drawing.Point(20, 220);
            this.RecentOrdersDataGridView.Name = "RecentOrdersDataGridView";
            this.RecentOrdersDataGridView.ReadOnly = true;
            this.RecentOrdersDataGridView.Size = new System.Drawing.Size(600, 170);
            this.RecentOrdersDataGridView.TabIndex = 3;
            this.RecentOrdersDataGridView.SelectionChanged += new System.EventHandler(this.RecentOrdersDataGridView_SelectionChanged);
            this.RecentOrdersDataGridView.Columns.Add("OrderID", "Order ID");
            this.RecentOrdersDataGridView.Columns.Add("Customer", "Customer");
            this.RecentOrdersDataGridView.Columns.Add("Date", "Date");
            this.RecentOrdersDataGridView.Columns.Add("Amount", "Amount");
            this.RecentOrdersDataGridView.Columns.Add("Status", "Status");

            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(20, 400);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(56, 15);
            this.OrderIdLabel.TabIndex = 4;
            this.OrderIdLabel.Text = "Order ID:";

            this.OrderIdTextBox.Location = new System.Drawing.Point(90, 396);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.ReadOnly = true;
            this.OrderIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.OrderIdTextBox.TabIndex = 5;

            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(210, 400);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(60, 15);
            this.CustomerLabel.TabIndex = 6;
            this.CustomerLabel.Text = "Customer:";

            this.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(280, 396);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(200, 23);
            this.CustomerComboBox.TabIndex = 7;

            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(20, 435);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(66, 15);
            this.OrderDateLabel.TabIndex = 8;
            this.OrderDateLabel.Text = "Order Date:";

            this.OrderDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrderDatePicker.Location = new System.Drawing.Point(90, 431);
            this.OrderDatePicker.Name = "OrderDatePicker";
            this.OrderDatePicker.Size = new System.Drawing.Size(130, 23);
            this.OrderDatePicker.TabIndex = 9;

            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Location = new System.Drawing.Point(240, 435);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.OrderStatusLabel.TabIndex = 10;
            this.OrderStatusLabel.Text = "Status:";

            this.OrderStatusTextBox.Location = new System.Drawing.Point(290, 431);
            this.OrderStatusTextBox.Name = "OrderStatusTextBox";
            this.OrderStatusTextBox.Size = new System.Drawing.Size(190, 23);
            this.OrderStatusTextBox.TabIndex = 11;

            this.AddOrderButton.Location = new System.Drawing.Point(20, 470);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(120, 28);
            this.AddOrderButton.TabIndex = 12;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);

            this.UpdateOrderButton.Location = new System.Drawing.Point(150, 470);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(120, 28);
            this.UpdateOrderButton.TabIndex = 13;
            this.UpdateOrderButton.Text = "Update Order";
            this.UpdateOrderButton.UseVisualStyleBackColor = true;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);

            this.DeleteOrderButton.Location = new System.Drawing.Point(280, 470);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(120, 28);
            this.DeleteOrderButton.TabIndex = 14;
            this.DeleteOrderButton.Text = "Delete Order";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);

            this.RefreshOrdersButton.Location = new System.Drawing.Point(410, 470);
            this.RefreshOrdersButton.Name = "RefreshOrdersButton";
            this.RefreshOrdersButton.Size = new System.Drawing.Size(120, 28);
            this.RefreshOrdersButton.TabIndex = 15;
            this.RefreshOrdersButton.Text = "Refresh";
            this.RefreshOrdersButton.UseVisualStyleBackColor = true;
            this.RefreshOrdersButton.Click += new System.EventHandler(this.RefreshOrdersButton_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RefreshOrdersButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.UpdateOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderStatusTextBox);
            this.Controls.Add(this.OrderStatusLabel);
            this.Controls.Add(this.OrderDatePicker);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.OrderIdTextBox);
            this.Controls.Add(this.OrderIdLabel);
            this.Controls.Add(this.RecentOrdersDataGridView);
            this.Controls.Add(this.RecentOrdersLabel);
            this.Controls.Add(this.StatsPanel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(650, 500);
            this.Load += new System.EventHandler(this.DashboardPanel_Load);

            this.StatsPanel.ResumeLayout(false);
            this.OrdersPanel.ResumeLayout(false);
            this.OrdersPanel.PerformLayout();
            this.RevenuePanel.ResumeLayout(false);
            this.RevenuePanel.PerformLayout();
            this.PendingOrdersPanel.ResumeLayout(false);
            this.PendingOrdersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecentOrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Panel PendingOrdersPanel;
        private System.Windows.Forms.Label PendingOrdersLabel;
        private System.Windows.Forms.Label PendingOrdersValueLabel;
        private System.Windows.Forms.Panel RevenuePanel;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label TotalRevenueLabel;
        private System.Windows.Forms.Panel OrdersPanel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label TotalOrdersLabel;
        private System.Windows.Forms.Label RecentOrdersLabel;
        private System.Windows.Forms.DataGridView RecentOrdersDataGridView;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.DateTimePicker OrderDatePicker;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.TextBox OrderStatusTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button RefreshOrdersButton;
    }
}
