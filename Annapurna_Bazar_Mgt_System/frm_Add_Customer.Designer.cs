namespace Annapurna_Bazar_Mgt_System
{
    partial class frm_Add_Customer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset_category = new Annapurna_Bazar_Mgt_System.dataset_category();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Add_Customer = new System.Windows.Forms.DataGridView();
            this.Cust_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.cb_Product_Name = new System.Windows.Forms.ComboBox();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Percentage_Discount = new System.Windows.Forms.Label();
            this.lbl_Percentages_GST = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.D_T_P = new System.Windows.Forms.DateTimePicker();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gst_price = new System.Windows.Forms.TextBox();
            this.tb_Totalbill = new System.Windows.Forms.TextBox();
            this.tbl_ProductTableAdapter = new Annapurna_Bazar_Mgt_System.dataset_categoryTableAdapters.tbl_ProductTableAdapter();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_category)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Category
            // 
            this.cb_Category.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(37, 65);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(260, 33);
            this.cb_Category.TabIndex = 5;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tbl_Product";
            this.tblProductBindingSource.DataSource = this.dataset_category;
            // 
            // dataset_category
            // 
            this.dataset_category.DataSetName = "dataset_category";
            this.dataset_category.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_GST
            // 
            this.tb_GST.Enabled = false;
            this.tb_GST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(622, 21);
            this.tb_GST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GST.MaxLength = 4;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(123, 30);
            this.tb_GST.TabIndex = 12;
            this.tb_GST.Text = "18";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(939, 25);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(140, 34);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.Location = new System.Drawing.Point(40, 20);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(159, 34);
            this.lbl_Total_Bill.TabIndex = 1;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.Location = new System.Drawing.Point(1243, 20);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(164, 34);
            this.lbl_Final_Bill.TabIndex = 1;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Indigo;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1097, 858);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 59);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(363, 15);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(217, 34);
            this.lbl_Product_Name.TabIndex = 1;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cb_Unit
            // 
            this.cb_Unit.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.cb_Unit.Enabled = false;
            this.cb_Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.Items.AddRange(new object[] {
            "Kg",
            "ml",
            "gram",
            "li"});
            this.cb_Unit.Location = new System.Drawing.Point(655, 65);
            this.cb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.Size = new System.Drawing.Size(205, 33);
            this.cb_Unit.TabIndex = 7;
            this.cb_Unit.SelectedIndexChanged += new System.EventHandler(this.cb_Unit_SelectedIndexChanged);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Discount.Location = new System.Drawing.Point(870, 20);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(143, 34);
            this.lbl_Discount.TabIndex = 1;
            this.lbl_Discount.Text = "Discount";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(1371, 25);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(176, 34);
            this.lbl_Total_Price.TabIndex = 1;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.dgv_Add_Customer);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.lbl_Price);
            this.groupBox2.Controls.Add(this.lbl_Category);
            this.groupBox2.Controls.Add(this.lbl_Total_Price);
            this.groupBox2.Controls.Add(this.lbl_Product_Name);
            this.groupBox2.Controls.Add(this.lbl_Quantity);
            this.groupBox2.Controls.Add(this.cb_Category);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cb_Unit);
            this.groupBox2.Controls.Add(this.tb_Price);
            this.groupBox2.Controls.Add(this.cb_Product_Name);
            this.groupBox2.Controls.Add(this.tb_Total_Price);
            this.groupBox2.Controls.Add(this.tb_Quantity);
            this.groupBox2.Location = new System.Drawing.Point(39, 365);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1873, 326);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // dgv_Add_Customer
            // 
            this.dgv_Add_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Add_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Add_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Add_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust_id,
            this.Date,
            this.Category,
            this.Product_name,
            this.Quantity,
            this.Price,
            this.Total_price});
            this.dgv_Add_Customer.Location = new System.Drawing.Point(37, 115);
            this.dgv_Add_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Add_Customer.Name = "dgv_Add_Customer";
            this.dgv_Add_Customer.RowTemplate.Height = 24;
            this.dgv_Add_Customer.Size = new System.Drawing.Size(1771, 190);
            this.dgv_Add_Customer.TabIndex = 12;
            // 
            // Cust_id
            // 
            this.Cust_id.HeaderText = "Customer_id";
            this.Cust_id.Name = "Cust_id";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Category
            // 
            this.Category.HeaderText = "Product Category";
            this.Category.Name = "Category";
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product Name";
            this.Product_name.Name = "Product_name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total_price
            // 
            this.Total_price.HeaderText = "Total Price";
            this.Total_price.Name = "Total_price";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Indigo;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1602, 47);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(162, 59);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(1167, 25);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(91, 34);
            this.lbl_Price.TabIndex = 1;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(100, 15);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(136, 34);
            this.lbl_Category.TabIndex = 1;
            this.lbl_Category.Text = "Category";
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(1123, 68);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Price.MaxLength = 8;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(185, 30);
            this.tb_Price.TabIndex = 9;
            // 
            // cb_Product_Name
            // 
            this.cb_Product_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Product_Name.FormattingEnabled = true;
            this.cb_Product_Name.Location = new System.Drawing.Point(335, 65);
            this.cb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Product_Name.Name = "cb_Product_Name";
            this.cb_Product_Name.Size = new System.Drawing.Size(260, 33);
            this.cb_Product_Name.TabIndex = 6;
            this.cb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cb_Product_Name_SelectedIndexChanged);
            this.cb_Product_Name.Leave += new System.EventHandler(this.cb_Product_Name_Leave);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1368, 68);
            this.tb_Total_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total_Price.MaxLength = 8;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(180, 30);
            this.tb_Total_Price.TabIndex = 10;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(933, 68);
            this.tb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(151, 30);
            this.tb_Quantity.TabIndex = 8;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1429, 20);
            this.tb_Final_Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Final_Bill.MaxLength = 8;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(225, 30);
            this.tb_Final_Bill.TabIndex = 14;
            // 
            // lbl_Percentage_Discount
            // 
            this.lbl_Percentage_Discount.AutoSize = true;
            this.lbl_Percentage_Discount.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percentage_Discount.Location = new System.Drawing.Point(1175, 23);
            this.lbl_Percentage_Discount.Name = "lbl_Percentage_Discount";
            this.lbl_Percentage_Discount.Size = new System.Drawing.Size(29, 31);
            this.lbl_Percentage_Discount.TabIndex = 1;
            this.lbl_Percentage_Discount.Text = "%";
            // 
            // lbl_Percentages_GST
            // 
            this.lbl_Percentages_GST.AutoSize = true;
            this.lbl_Percentages_GST.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percentages_GST.Location = new System.Drawing.Point(741, 21);
            this.lbl_Percentages_GST.Name = "lbl_Percentages_GST";
            this.lbl_Percentages_GST.Size = new System.Drawing.Size(29, 31);
            this.lbl_Percentages_GST.TabIndex = 1;
            this.lbl_Percentages_GST.Text = "%";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(757, 858);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(178, 59);
            this.btn_Refresh.TabIndex = 29;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(513, 21);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(77, 34);
            this.lbl_GST.TabIndex = 1;
            this.lbl_GST.Text = "GST";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.D_T_P);
            this.groupBox1.Controls.Add(this.lbl_Customer_Name);
            this.groupBox1.Controls.Add(this.lbl_Customer_Id);
            this.groupBox1.Controls.Add(this.lbl_Mobile_No);
            this.groupBox1.Controls.Add(this.lbl_Date);
            this.groupBox1.Controls.Add(this.tb_Customer_Name);
            this.groupBox1.Controls.Add(this.tb_Customer_ID);
            this.groupBox1.Controls.Add(this.tb_Mobile_No);
            this.groupBox1.Location = new System.Drawing.Point(39, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1873, 150);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // D_T_P
            // 
            this.D_T_P.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.D_T_P.Enabled = false;
            this.D_T_P.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_T_P.Location = new System.Drawing.Point(1261, 18);
            this.D_T_P.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D_T_P.Name = "D_T_P";
            this.D_T_P.Size = new System.Drawing.Size(395, 31);
            this.D_T_P.TabIndex = 2;
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.Location = new System.Drawing.Point(71, 90);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(236, 34);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.Location = new System.Drawing.Point(71, 23);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(188, 34);
            this.lbl_Customer_Id.TabIndex = 1;
            this.lbl_Customer_Id.Text = "Customer Id";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(1019, 90);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(164, 34);
            this.lbl_Mobile_No.TabIndex = 1;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(1019, 23);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(81, 34);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(396, 90);
            this.tb_Customer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Customer_Name.MaxLength = 80;
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(401, 31);
            this.tb_Customer_Name.TabIndex = 3;
            this.tb_Customer_Name.Text = "Ashsih";
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(396, 23);
            this.tb_Customer_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Customer_ID.MaxLength = 5;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(399, 31);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1261, 90);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(395, 31);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.Text = "9284487145";
            // 
            // tb_Discount
            // 
            this.tb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Discount.Location = new System.Drawing.Point(1026, 23);
            this.tb_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Discount.MaxLength = 3;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(145, 30);
            this.tb_Discount.TabIndex = 13;
            this.tb_Discount.Text = "0";
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.Enter += new System.EventHandler(this.tb_Discount_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_gst_price);
            this.groupBox3.Controls.Add(this.tb_GST);
            this.groupBox3.Controls.Add(this.lbl_Total_Bill);
            this.groupBox3.Controls.Add(this.lbl_Final_Bill);
            this.groupBox3.Controls.Add(this.lbl_Discount);
            this.groupBox3.Controls.Add(this.lbl_Percentage_Discount);
            this.groupBox3.Controls.Add(this.lbl_Percentages_GST);
            this.groupBox3.Controls.Add(this.tb_Final_Bill);
            this.groupBox3.Controls.Add(this.tb_Discount);
            this.groupBox3.Controls.Add(this.tb_Totalbill);
            this.groupBox3.Controls.Add(this.lbl_GST);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 717);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1870, 121);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rs";
            // 
            // tb_gst_price
            // 
            this.tb_gst_price.Enabled = false;
            this.tb_gst_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gst_price.Location = new System.Drawing.Point(622, 67);
            this.tb_gst_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_gst_price.MaxLength = 4;
            this.tb_gst_price.Name = "tb_gst_price";
            this.tb_gst_price.Size = new System.Drawing.Size(123, 30);
            this.tb_gst_price.TabIndex = 15;
            this.tb_gst_price.Text = "18";
            // 
            // tb_Totalbill
            // 
            this.tb_Totalbill.Enabled = false;
            this.tb_Totalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Totalbill.Location = new System.Drawing.Point(217, 20);
            this.tb_Totalbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Totalbill.MaxLength = 8;
            this.tb_Totalbill.Name = "tb_Totalbill";
            this.tb_Totalbill.Size = new System.Drawing.Size(196, 30);
            this.tb_Totalbill.TabIndex = 11;
            this.tb_Totalbill.Text = "0";
            // 
            // tbl_ProductTableAdapter
            // 
            this.tbl_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1924, 100);
            this.Panel1.TabIndex = 44;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(822, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(376, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "NEW INVOICE";
            // 
            // frm_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_Add_Customer";
            this.Load += new System.EventHandler(this.frm_Add_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_category)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cb_Unit;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Add_Customer;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.ComboBox cb_Product_Name;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Percentage_Discount;
        private System.Windows.Forms.Label lbl_Percentages_GST;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker D_T_P;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Totalbill;
        private dataset_category dataset_category;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private dataset_categoryTableAdapters.tbl_ProductTableAdapter tbl_ProductTableAdapter;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_gst_price;
    }
}