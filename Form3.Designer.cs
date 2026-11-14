namespace WinFormsApp1
{
    partial class Form3
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
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            lblTotalProducts = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblInStock = new Label();
            label3 = new Label();
            panel3 = new Panel();
            lblLowStock = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblOutOfStock = new Label();
            label5 = new Label();
            panel5 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            txtReorderLevel = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label17 = new Label();
            label16 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 55);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Khaki;
            button1.Location = new Point(352, 12);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(126, 57);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalProducts);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(125, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 150);
            panel1.TabIndex = 2;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(95, 87);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(24, 26);
            lblTotalProducts.TabIndex = 6;
            lblTotalProducts.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(162, 26);
            label2.TabIndex = 0;
            label2.Text = "Total Products";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblInStock);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(361, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 150);
            panel2.TabIndex = 3;
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInStock.Location = new Point(93, 87);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(24, 26);
            lblInStock.TabIndex = 7;
            lblInStock.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 32);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 6;
            label3.Text = "In Stock";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblLowStock);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(596, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 150);
            panel3.TabIndex = 4;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(97, 87);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(24, 26);
            lblLowStock.TabIndex = 7;
            lblLowStock.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 32);
            label4.Name = "label4";
            label4.Size = new Size(120, 26);
            label4.TabIndex = 6;
            label4.Text = "Low Stock";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblOutOfStock);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(828, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 150);
            panel4.TabIndex = 5;
            // 
            // lblOutOfStock
            // 
            lblOutOfStock.AutoSize = true;
            lblOutOfStock.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutOfStock.Location = new Point(94, 87);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(24, 26);
            lblOutOfStock.TabIndex = 7;
            lblOutOfStock.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 32);
            label5.Name = "label5";
            label5.Size = new Size(140, 26);
            label5.TabIndex = 6;
            label5.Text = "Out of Stock";
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnClear);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(cmbCategory);
            panel5.Controls.Add(txtReorderLevel);
            panel5.Controls.Add(txtDescription);
            panel5.Controls.Add(txtQuantity);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(txtProductName);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(21, 233);
            panel5.Name = "panel5";
            panel5.Size = new Size(1110, 192);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.ForeColor = Color.Khaki;
            btnClear.Location = new Point(901, 136);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(168, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.ForeColor = Color.Khaki;
            btnDelete.Location = new Point(901, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.ForeColor = Color.Khaki;
            btnUpdate.Location = new Point(901, 56);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.Khaki;
            btnAdd.Location = new Point(901, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Motorcycle Parts", "Smartphones", "Appliances", "Laptops", "School Suplies", "Accessories", "Beauti Cosmetics", "Eletronics" });
            cmbCategory.Location = new Point(576, 119);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(270, 33);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(300, 119);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(270, 31);
            txtReorderLevel.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 119);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(270, 60);
            txtDescription.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(576, 41);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(270, 31);
            txtQuantity.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(300, 41);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(270, 31);
            txtUnitPrice.TabIndex = 7;
            txtUnitPrice.TextChanged += textBox2_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(24, 41);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(270, 31);
            txtProductName.TabIndex = 6;
            txtProductName.TextChanged += textBox1_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(576, 94);
            label15.Name = "label15";
            label15.Size = new Size(81, 22);
            label15.TabIndex = 5;
            label15.Text = "Category";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(576, 16);
            label14.Name = "label14";
            label14.Size = new Size(76, 22);
            label14.TabIndex = 4;
            label14.Text = "Quantity";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(300, 94);
            label13.Name = "label13";
            label13.Size = new Size(125, 22);
            label13.TabIndex = 3;
            label13.Text = "Reorder Level";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(300, 16);
            label12.Name = "label12";
            label12.Size = new Size(90, 22);
            label12.TabIndex = 2;
            label12.Text = "Unit Price";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(24, 94);
            label11.Name = "label11";
            label11.Size = new Size(103, 22);
            label11.TabIndex = 1;
            label11.Text = "Description";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 16);
            label10.Name = "label10";
            label10.Size = new Size(122, 22);
            label10.TabIndex = 0;
            label10.Text = "Product Name";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dgvProducts);
            panel6.Controls.Add(btnRefresh);
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Location = new Point(21, 431);
            panel6.Name = "panel6";
            panel6.Size = new Size(1110, 307);
            panel6.TabIndex = 7;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(39, 49);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1030, 255);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Black;
            btnRefresh.ForeColor = Color.Khaki;
            btnRefresh.Location = new Point(186, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(836, 9);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(764, 12);
            label17.Name = "label17";
            label17.Size = new Size(64, 22);
            label17.TabIndex = 1;
            label17.Text = "Search";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(39, 11);
            label16.Name = "label16";
            label16.Size = new Size(141, 26);
            label16.TabIndex = 0;
            label16.Text = "Product List";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form3";
            Text = "Dashboard Form";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotalProducts;
        private Label lblInStock;
        private Label lblLowStock;
        private Label lblOutOfStock;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtQuantity;
        private TextBox txtReorderLevel;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private Label label16;
        private Label label17;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
    }
}