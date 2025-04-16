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

    
    public partial class AddProductForm : Form
    {
        // خاصية لتخزين المنتج الجديد المضاف
        public Product NewProduct { get; private set; }
        ProductManagementForm pdm;
        public AddProductForm( ProductManagementForm pdm)
        {
            InitializeComponent();
            this .pdm = pdm;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // اختيار صورة من الحاسوب وعرضها في PictureBox
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "صور (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProduct.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

       

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            // التحقق من إدخال بيانات المنتج
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || numPrice.Value <= 0 || numQuantityInStock.Value < 0)
            {
                MessageBox.Show("يرجى إدخال جميع البيانات المطلوبة بشكل صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // إنشاء المنتج الجديد
            NewProduct = new Product
            {
                Name = txtProductName.Text,
                Price = numPrice.Value,
                QuantityInStock = (int)numQuantityInStock.Value,
                ID = pdm.dataGridViewProducts.Rows.Count,
                filepath = filepath.Text
            };

            // إغلاق النموذج وإعادة النتيجة كـ DialogResult.OK
            DialogResult = DialogResult.OK;
            MessageBox.Show("تم الحفظ بنجاح");

            Close();
        }

        private void BtnOpen_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = opf.FileName;
                pictureBoxProduct.Image = Image.FromFile(filepath.Text);
            }
        }
    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public string filepath { get; set; }


    }
}
