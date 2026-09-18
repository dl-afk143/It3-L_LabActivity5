namespace LabActivity4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCustomerEmail = new TextBox();
            label6 = new Label();
            cmbDiscount = new ComboBox();
            btnCalculate = new Button();
            btnSaveOrder = new Button();
            btnEmailnvoice = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            label8 = new Label();
            dgvItems = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 0;
            label1.Text = "Order Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 88);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 1;
            label2.Text = "Customer Email:";
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(170, 86);
            txtCustomerEmail.Multiline = true;
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(208, 23);
            txtCustomerEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(41, 390);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 7;
            label6.Text = "Discount:";
            // 
            // cmbDiscount
            // 
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Items.AddRange(new object[] { "None", "Student", "Senior", "BlackFriday" });
            cmbDiscount.Location = new Point(133, 392);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(121, 23);
            cmbDiscount.TabIndex = 8;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(41, 462);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 48);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Font = new Font("Segoe UI", 12F);
            btnSaveOrder.Location = new Point(154, 462);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(109, 48);
            btnSaveOrder.TabIndex = 10;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnEmailnvoice
            // 
            btnEmailnvoice.Font = new Font("Segoe UI", 12F);
            btnEmailnvoice.Location = new Point(269, 462);
            btnEmailnvoice.Name = "btnEmailnvoice";
            btnEmailnvoice.Size = new Size(122, 48);
            btnEmailnvoice.TabIndex = 11;
            btnEmailnvoice.Text = "Email Invoice";
            btnEmailnvoice.UseVisualStyleBackColor = true;
            btnEmailnvoice.Click += btnEmailnvoice_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 12F);
            btnPrint.Location = new Point(41, 545);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(107, 48);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.Location = new Point(84, 644);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 21);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(33, 644);
            label8.Name = "label8";
            label8.Size = new Size(45, 21);
            label8.TabIndex = 13;
            label8.Text = "Total:";
            // 
            // dgvItems
            // 
            dgvItems.BackgroundColor = SystemColors.Window;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            dgvItems.Location = new Point(84, 160);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(341, 172);
            dgvItems.TabIndex = 14;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(938, 755);
            Controls.Add(dgvItems);
            Controls.Add(label8);
            Controls.Add(lblTotal);
            Controls.Add(btnPrint);
            Controls.Add(btnEmailnvoice);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCalculate);
            Controls.Add(cmbDiscount);
            Controls.Add(label6);
            Controls.Add(txtCustomerEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerEmail;
        private Label label6;
        private ComboBox cmbDiscount;
        private Button btnCalculate;
        private Button btnSaveOrder;
        private Button btnEmailnvoice;
        private Button btnPrint;
        private Label lblTotal;
        private Label label8;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
    }
}
