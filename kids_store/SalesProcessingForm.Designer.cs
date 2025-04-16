namespace kids_store
{
    partial class SalesProcessingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcessSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(794, 391);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(192, 59);
            this.btnAddToSale.TabIndex = 0;
            this.btnAddToSale.Text = " add to sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.BtnAddToSale_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "num";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(309, 491);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(186, 33);
            this.cmbProducts.TabIndex = 2;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productPrice,
            this.quantity,
            this.totalCost});
            this.dgvSales.Location = new System.Drawing.Point(35, 43);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 82;
            this.dgvSales.RowTemplate.Height = 35;
            this.dgvSales.Size = new System.Drawing.Size(898, 234);
            this.dgvSales.TabIndex = 3;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(309, 428);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(186, 33);
            this.cmbCustomers.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(110, 428);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(171, 33);
            this.txtQuantity.TabIndex = 5;
            // 
            // productName
            // 
            this.productName.HeaderText = "productName";
            this.productName.MinimumWidth = 10;
            this.productName.Name = "productName";
            this.productName.Width = 200;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "productPrice";
            this.productPrice.MinimumWidth = 10;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            this.quantity.Width = 200;
            // 
            // totalCost
            // 
            this.totalCost.HeaderText = "totalCost";
            this.totalCost.MinimumWidth = 10;
            this.totalCost.Name = "totalCost";
            this.totalCost.Width = 200;
            // 
            // btnProcessSale
            // 
            this.btnProcessSale.Location = new System.Drawing.Point(794, 468);
            this.btnProcessSale.Name = "btnProcessSale";
            this.btnProcessSale.Size = new System.Drawing.Size(192, 59);
            this.btnProcessSale.TabIndex = 6;
            this.btnProcessSale.Text = "sale";
            this.btnProcessSale.UseVisualStyleBackColor = true;
            this.btnProcessSale.Click += new System.EventHandler(this.BtnProcessSale_Click_1);
            // 
            // SalesProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 636);
            this.Controls.Add(this.btnProcessSale);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToSale);
            this.Name = "SalesProcessingForm";
            this.Text = "SalesProcessingForm";
            this.Load += new System.EventHandler(this.SalesProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost;
        private System.Windows.Forms.Button btnProcessSale;
    }
}