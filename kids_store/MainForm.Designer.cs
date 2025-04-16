namespace kids_store
{
    partial class MainForm
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
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.btnSalesProcessing = new System.Windows.Forms.Button();
            this.btnSalesReport_Click = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Location = new System.Drawing.Point(782, 76);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(261, 76);
            this.btnProductManagement.TabIndex = 0;
            this.btnProductManagement.Text = "ProductManagement";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.BtnProductManagement_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.Location = new System.Drawing.Point(782, 202);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Size = new System.Drawing.Size(261, 76);
            this.btnCustomerManagement.TabIndex = 1;
            this.btnCustomerManagement.Text = "CustomerManagement";
            this.btnCustomerManagement.UseVisualStyleBackColor = true;
            this.btnCustomerManagement.Click += new System.EventHandler(this.BtnCustomerManagement_Click);
            // 
            // btnSalesProcessing
            // 
            this.btnSalesProcessing.Location = new System.Drawing.Point(782, 332);
            this.btnSalesProcessing.Name = "btnSalesProcessing";
            this.btnSalesProcessing.Size = new System.Drawing.Size(261, 76);
            this.btnSalesProcessing.TabIndex = 2;
            this.btnSalesProcessing.Text = "SalesProcessing";
            this.btnSalesProcessing.UseVisualStyleBackColor = true;
            this.btnSalesProcessing.Click += new System.EventHandler(this.BtnSalesProcessing_Click);
            // 
            // btnSalesReport_Click
            // 
            this.btnSalesReport_Click.Location = new System.Drawing.Point(782, 470);
            this.btnSalesReport_Click.Name = "btnSalesReport_Click";
            this.btnSalesReport_Click.Size = new System.Drawing.Size(261, 76);
            this.btnSalesReport_Click.TabIndex = 3;
            this.btnSalesReport_Click.Text = "SalesReport";
            this.btnSalesReport_Click.UseVisualStyleBackColor = true;
            this.btnSalesReport_Click.Click += new System.EventHandler(this.BtnSalesReport_Click_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(33, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 603);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 727);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalesReport_Click);
            this.Controls.Add(this.btnSalesProcessing);
            this.Controls.Add(this.btnCustomerManagement);
            this.Controls.Add(this.btnProductManagement);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnSalesProcessing;
        private System.Windows.Forms.Button btnSalesReport_Click;
        private System.Windows.Forms.Panel panel1;
    }
}