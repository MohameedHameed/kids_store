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
    public partial class ProductManagementForm : Form
    {
        // قائمة لتخزين المنتجات المحلية

        public ProductManagementForm()
        {
            InitializeComponent();
        }
        static int c = 0;

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            
            // عرض البيانات في جدول
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            // يتم مسح البيانات القديمة
            dataGridViewProducts.Rows.Clear();

            // يتم عرض بيانات كل منتج في القائمة
            foreach (var product in   MainForm.products)
            {
                dataGridViewProducts.Rows.Add(product.ID, product.Name, product.Price, product.QuantityInStock,product.filepath);
            }
        }

      

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddProduct_Click_1(object sender, EventArgs e)
        {
            // فتح نافذة لإضافة منتج جديد
            AddProductForm addProductForm = new AddProductForm(this);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                // بعد الإضافة، يتم تحديث البيانات وعرضها مجدداً
                MainForm.products.Add(addProductForm.NewProduct);
                DisplayProducts();
            }
        }

        private void DataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(dataGridViewProducts.CurrentRow.Cells[4].Value.ToString());
            }
            catch(Exception ex)
            {

            }
        }
    }
}
