using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckOrdersPanel : UserControl
    {
        private OrderService orderService;

        public CheckOrdersPanel()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void CheckOrdersPanel_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllOrders()
        {
            ResultsDataGridView.Rows.Clear();
            List<Order> orders = orderService.GetAllOrders();

            foreach (Order order in orders)
            {
                ResultsDataGridView.Rows.Add(
                    order.OrderId,
                    order.CustomerName,
                    "₱" + order.TotalAmount.ToString("F2"),
                    order.OrderStatus,
                    order.OrderDate.ToString("yyyy-MM-dd")
                );
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string orderIDText = OrderIDTextBox.Text.Trim();

            if (string.IsNullOrEmpty(orderIDText))
            {
                MessageBox.Show("Please enter an Order ID or leave empty to see all orders.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(orderIDText, out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order order = orderService.GetOrderById(orderId);
                ResultsDataGridView.Rows.Clear();

                if (order != null)
                {
                    ResultsDataGridView.Rows.Add(
                        order.OrderId,
                        order.CustomerName,
                        "₱" + order.TotalAmount.ToString("F2"),
                        order.OrderStatus,
                        order.OrderDate.ToString("yyyy-MM-dd")
                    );
                }
                else
                {
                    MessageBox.Show("Order not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OrderIDTextBox.Clear();
            LoadAllOrders();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllOrders();
                MessageBox.Show("Orders refreshed successfully.", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            if (ResultsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = (int)ResultsDataGridView.SelectedRows[0].Cells[0].Value;
            string currentStatus = (string)ResultsDataGridView.SelectedRows[0].Cells[3].Value;

            using (Form statusForm = new Form())
            {
                statusForm.Text = "Update Order Status";
                statusForm.Width = 300;
                statusForm.Height = 150;
                statusForm.StartPosition = FormStartPosition.CenterParent;

                ComboBox statusCombo = new ComboBox();
                statusCombo.Items.AddRange(new[] { "Pending", "Completed", "Cancelled" });
                statusCombo.SelectedItem = currentStatus;
                statusCombo.Location = new System.Drawing.Point(10, 20);
                statusCombo.Width = 260;

                Button okBtn = new Button();
                okBtn.Text = "OK";
                okBtn.Location = new System.Drawing.Point(100, 60);
                okBtn.DialogResult = DialogResult.OK;

                Button cancelBtn = new Button();
                cancelBtn.Text = "Cancel";
                cancelBtn.Location = new System.Drawing.Point(180, 60);
                cancelBtn.DialogResult = DialogResult.Cancel;

                statusForm.Controls.Add(statusCombo);
                statusForm.Controls.Add(okBtn);
                statusForm.Controls.Add(cancelBtn);

                if (statusForm.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        orderService.UpdateOrderStatus(orderId, statusCombo.SelectedItem.ToString());
                        MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
