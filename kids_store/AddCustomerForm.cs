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

    
    public partial class AddCustomerForm : Form
    {
        // خاصية لتخزين المنتج الجديد المضاف
        public Customer NewCustomer { get; private set; }
        CustomerManagementForm cdm;
        public AddCustomerForm(CustomerManagementForm cdm)
        {
            InitializeComponent();
            this .cdm = cdm;
        }


       

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            // التحقق من إدخال بيانات المنتج
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomercontactinfo.Text))
            {
                MessageBox.Show("يرجى إدخال جميع البيانات المطلوبة بشكل صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // إنشاء المنتج الجديد
            NewCustomer = new Customer
            {
                Name = txtCustomerName.Text,
                Contactinfo = txtCustomercontactinfo.Text,
                ID = cdm.dataGridViewProducts.Rows.Count,
            };

            // إغلاق النموذج وإعادة النتيجة كـ DialogResult.OK
            DialogResult = DialogResult.OK;
            MessageBox.Show("تم الحفظ بنجاح");

            Close();
        }


    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contactinfo { get; set; }
 


    }
}
