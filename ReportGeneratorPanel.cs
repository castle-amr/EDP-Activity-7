using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ReportGeneratorPanel : UserControl
    {
        private OrderService orderService;

        public ReportGeneratorPanel()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string reportType = OrderSummaryComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Please select a report type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string filePath = GenerateReport(reportType);

                DialogResult result = MessageBox.Show(
                    $"Report generated successfully!\n\nFile: {Path.GetFileName(filePath)}\n\nDo you want to open the file?",
                    "Report Generated",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateReport(string reportType)
        {
            string fileName = "";
            string filePath = "";
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;

            // Determine date range based on report type
            switch (reportType)
            {
                case "Daily Summary":
                    startDate = DateTime.Now.Date;
                    endDate = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
                    fileName = $"Daily_Report_{DateTime.Now:yyyy-MM-dd}.xlsx";
                    break;

                case "Weekly Summary":
                    startDate = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
                    endDate = startDate.AddDays(7).AddSeconds(-1);
                    fileName = $"Weekly_Report_{DateTime.Now:yyyy-MM-dd}.xlsx";
                    break;

                case "Monthly Summary":
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    endDate = startDate.AddMonths(1).AddSeconds(-1);
                    fileName = $"Monthly_Report_{DateTime.Now:yyyy-MM}.xlsx";
                    break;

                case "Custom Range":
                    // For custom range, use current month for now
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    endDate = DateTime.Now;
                    fileName = $"Custom_Report_{DateTime.Now:yyyy-MM-dd_HHmmss}.xlsx";
                    break;
            }

            // Create reports folder if it doesn't exist
            string reportsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "E-ComTrack Reports");
            if (!Directory.Exists(reportsFolder))
            {
                Directory.CreateDirectory(reportsFolder);
            }

            filePath = Path.Combine(reportsFolder, fileName);

            // Get orders for the date range
            List<Order> orders = orderService.GetOrdersByDateRange(startDate, endDate);

            // Generate Excel report with professional formatting
            return ExcelReportGenerator.GenerateOrderReportExcel(orders, $"{reportType} - {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}", filePath);
        }

        private void ReportGeneratorPanel_Load(object sender, EventArgs e)
        {
            OrderSummaryComboBox.Items.Add("Daily Summary");
            OrderSummaryComboBox.Items.Add("Weekly Summary");
            OrderSummaryComboBox.Items.Add("Monthly Summary");
            OrderSummaryComboBox.Items.Add("Custom Range");
        }
    }
}
