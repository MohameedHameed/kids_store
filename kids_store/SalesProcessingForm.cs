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
    public partial class SalesProcessingForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<Customer> customers = new List<Customer>();
        public SalesProcessingForm()
        {
            InitializeComponent();
        }

        private void SalesProcessingForm_Load(object sender, EventArgs e)
        {
            // قم بتحميل العملاء والمنتجات عند تحميل النموذج
            LoadCustomers();
            LoadProducts();
        }
        private void LoadCustomers()
        {
            // قم بإضافة عملاء للاختبار
            List<string> customers_names = new List<string>();
            foreach (Customer customer in MainForm.customers)
            {
                customers_names.Add(customer.Name);

            }
            cmbCustomers.Items.AddRange(customers_names.ToArray());
        }

        private void LoadProducts()
        {

            List<string> Product_names = new List<string>();
         


            foreach (Product product in MainForm.products)
            {
                Product_names.Add(product.Name);
            } cmbProducts.Items.AddRange(Product_names.ToArray());
        }    

        
      

        private void BtnAddToSale_Click_1(object sender, EventArgs e)
        {
            // التأكد من أنه تم تحديد منتج وكمية
            if (cmbProducts.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("الرجاء تحديد منتج وإدخال كمية.");
                return;
            }

            // التحقق من توفر كمية كافية في المخزون
            int selectedProductIndex = cmbProducts.SelectedIndex;
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("الرجاء إدخال كمية صحيحة.");
                return;
            }

            if (quantity > MainForm.products[selectedProductIndex].QuantityInStock)
            {
                MessageBox.Show("الكمية المطلوبة غير متوفرة في المخزون.");
                return;
            }

            // إضافة المنتج إلى البيع
            string productName = cmbProducts.SelectedItem.ToString();
            decimal productPrice = MainForm.products[selectedProductIndex].Price;
            decimal totalCost = productPrice * quantity;

            dgvSales.Rows.Add(productName, productPrice, quantity, totalCost);

            // تحديث كمية المنتج في المخزون
            MainForm.products[selectedProductIndex].QuantityInStock -= quantity;
        }

        private void BtnProcessSale_Click_1(object sender, EventArgs e)
        {
            // إجراء البيع: يمكنك هنا تنفيذ الإجراءات المناسبة لمعالجة البيع، مثل طباعة الفاتورة، تحديث قاعدة البيانات، إلخ.
            // لهذا المثال، سنقوم فقط بعرض رسالة تأكيد.
            MessageBox.Show("تم معالجة البيع بنجاح.");

            // إفراغ البيانات بعد معالجة البيع
            dgvSales.Rows.Clear();
        }
    }
    }

