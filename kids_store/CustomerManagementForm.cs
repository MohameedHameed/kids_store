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
    public partial class CustomerManagementForm : Form
    {
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            
            DisplayCustomer();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void DisplayCustomer()
        {
            // يتم مسح البيانات القديمة
            dataGridViewProducts.Rows.Clear();

            // يتم عرض بيانات كل منتج في القائمة
            foreach (var customer in MainForm.customers)
            {
                dataGridViewProducts.Rows.Add(customer.ID, customer.Name, customer.Contactinfo);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(this);
            if (addCustomerForm.ShowDialog() == DialogResult.OK)
            {
                // بعد الإضافة، يتم تحديث البيانات وعرضها مجدداً
                MainForm.customers.Add(addCustomerForm.NewCustomer);
                DisplayCustomer();
            }
        }
    }
}
