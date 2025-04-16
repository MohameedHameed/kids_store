using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            

                // إضافة بعض البيانات للاختبار
                products.Add(new Product { ID = 1, Name = "كرة", Price = 10, QuantityInStock = 100 });
                products.Add(new Product { ID = 2, Name = "سيارة", Price = 15, QuantityInStock = 50, });
            customers.Add(new Customer { ID = 1, Name = "samah", Contactinfo = "74556863556" });
            customers.Add(new Customer { ID = 2, Name = "lean", Contactinfo = "7400335566" });
            customers.Add(new Customer { ID = 3, Name = "noura", Contactinfo = "7802546333" });
            customers.Add(new Customer { ID = 4, Name = "dana", Contactinfo = "7740231415" });

        }
        public static List<Product> products = new List<Product>();
        public static List<Customer> customers = new List<Customer>();


        private void BtnProductManagement_Click(object sender, EventArgs e)
            {
                // افتح واجهة إدارة المنتجات
                ProductManagementForm productManagementForm = new ProductManagementForm();
                productManagementForm.Show();
            }

            private void BtnCustomerManagement_Click(object sender, EventArgs e)
            {
                // افتح واجهة إدارة العملاء
                CustomerManagementForm customerManagementForm = new CustomerManagementForm();
                customerManagementForm.Show();
            }

            private void BtnSalesProcessing_Click(object sender, EventArgs e)
            {
                // افتح واجهة معالجة المبيعات
                SalesProcessingForm salesProcessingForm = new SalesProcessingForm();
                salesProcessingForm.Show();
            }

            private void BtnSalesReport_Click_Click(object sender, EventArgs e)
            {
                // افتح واجهة تقرير المبيعات
                SalesReportForm salesReportForm = new SalesReportForm();
                salesReportForm.Show();
            }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
