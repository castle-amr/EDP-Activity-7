using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DashboardPanel : UserControl
    {
        private OrderService orderService;
        private UserService userService;
        private Label AmountLabel;
        private TextBox AmountTextBox;
        private List<User> customers;
        private List<Order> orders;


        public DashboardPanel()
        {
            InitializeComponent();

            orderService = new OrderService();
            userService = new UserService();

            CreateAmountControls();
        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDashboardData();
                LoadOrderManagementData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                List<Order> allOrders = orderService.GetAllOrders();
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endDate = DateTime.Now;
                OrderService.SalesReport report = orderService.GetSalesReport(startDate, endDate);

                TotalOrdersLabel.Text = allOrders.Count.ToString();
                TotalRevenueLabel.Text = "P" + report.TotalRevenue.ToString("F2");

                double pendingPercentage = allOrders.Count > 0 ? (report.PendingOrders * 100.0 / allOrders.Count) : 0;
                PendingOrdersValueLabel.Text = pendingPercentage.ToString("F0") + "%";

                PopulateRecentOrders(allOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void LoadOrderManagementData()
        {
            try
            {
                customers = userService.GetAllUsers();
                orders = orderService.GetAllOrders();

                CustomerComboBox.DataSource = null;
                CustomerComboBox.DisplayMember = "FullName";
                CustomerComboBox.ValueMember = "UserId";
                CustomerComboBox.DataSource = customers;

                PopulateRecentOrders(orders);
                ClearOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order management data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateRecentOrders(List<Order> orders)
        {
            RecentOrdersDataGridView.Rows.Clear();

            foreach (Order order in orders)
            {
                RecentOrdersDataGridView.Rows.Add(
                    order.OrderId,
                    order.CustomerName,
                    order.OrderDate.ToShortDateString(),
                    "P" + order.TotalAmount.ToString("F2"),
                    order.OrderStatus
                );
            }
        }

        private void RecentOrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (RecentOrdersDataGridView.SelectedRows.Count == 0)
                return;

            DataGridViewRow selectedRow = RecentOrdersDataGridView.SelectedRows[0];
            if (selectedRow.Cells[0].Value == null)
                return;

            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            Order order = orderService.GetOrderById(orderId);
            if (order == null)
                return;

            OrderIdTextBox.Text = order.OrderId.ToString();
            OrderDatePicker.Value = order.OrderDate;
            OrderStatusTextBox.Text = order.OrderStatus;
            AmountTextBox.Text = order.TotalAmount.ToString("F2");

            for (int i = 0; i < CustomerComboBox.Items.Count; i++)
            {
                if (CustomerComboBox.Items[i] is User user && user.UserId == order.CustomerId)
                {
                    CustomerComboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CreateAmountControls()
        {
            AmountLabel = new Label();
            AmountLabel.Text = "Amount:";
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new System.Drawing.Point(450, 435);

            AmountTextBox = new TextBox();
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Location = new System.Drawing.Point(520, 432);
            AmountTextBox.Size = new System.Drawing.Size(120, 22);

            this.Controls.Add(AmountLabel);
            this.Controls.Add(AmountTextBox);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                User selectedCustomer = CustomerComboBox.SelectedItem as User;

                if (selectedCustomer == null)
                {
                    MessageBox.Show("Choose a customer for the new order.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(OrderStatusTextBox.Text))
                {
                    MessageBox.Show("Order status is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                decimal amount;

                if (!decimal.TryParse(AmountTextBox.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid amount.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Order order = new Order
                {
                    CustomerId = selectedCustomer.UserId,
                    OrderDate = OrderDatePicker.Value.Date,
                    OrderStatus = OrderStatusTextBox.Text.Trim(),
                    TotalAmount = amount
                };

                int insertedId = orderService.AddOrder(order);

                LoadDashboardData();
                LoadOrderManagementData();

                MessageBox.Show(
                    $"Order added successfully (ID: {insertedId}).",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                AmountTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add order: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(OrderIdTextBox.Text, out int orderId) || orderId <= 0)
                {
                    MessageBox.Show("Select an existing order to update.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                User selectedCustomer = CustomerComboBox.SelectedItem as User;

                if (selectedCustomer == null)
                {
                    MessageBox.Show("Choose a customer.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                decimal amount;

                if (!decimal.TryParse(AmountTextBox.Text, out amount))
                {
                    MessageBox.Show("Please enter a valid amount.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Order order = new Order
                {
                    OrderId = orderId,
                    CustomerId = selectedCustomer.UserId,
                    OrderDate = OrderDatePicker.Value.Date,
                    OrderStatus = OrderStatusTextBox.Text.Trim(),
                    TotalAmount = amount
                };

                bool updated = orderService.UpdateOrder(order);

                if (updated)
                {
                    LoadDashboardData();
                    LoadOrderManagementData();

                    MessageBox.Show(
                        "Order updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No order was updated.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update order: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(OrderIdTextBox.Text, out int orderId) || orderId <= 0)
                {
                    MessageBox.Show("Select an order to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                bool deleted = orderService.DeleteOrder(orderId);
                if (deleted)
                {
                    LoadDashboardData();
                    LoadOrderManagementData();
                    MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshOrdersButton_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadOrderManagementData();
        }

        private void ClearOrderForm()
        {
            OrderIdTextBox.Text = string.Empty;
            CustomerComboBox.SelectedIndex = -1;
            OrderDatePicker.Value = DateTime.Now;
            OrderStatusTextBox.Clear();

            if (AmountTextBox != null)
                AmountTextBox.Clear();
        }
    }
}
