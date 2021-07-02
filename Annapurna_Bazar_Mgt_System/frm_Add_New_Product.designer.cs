namespace APMS
{
    partial class frm_Add_New_Product
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
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.cb_Unit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Proportion = new System.Windows.Forms.Label();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_ManufacturePrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Specification = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Distributor_Id = new System.Windows.Forms.Label();
            this.txt_Distributor_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Stock = new System.Windows.Forms.TextBox();
            this.tb_gst = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(1172, 318);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(173, 34);
            this.lbl_Sales_Price.TabIndex = 6;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Enabled = false;
            this.tb_Product_Id.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(244, 38);
            this.tb_Product_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_Id.MaxLength = 5;
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(167, 31);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // cb_Unit
            // 
            this.cb_Unit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Unit.FormattingEnabled = true;
            this.cb_Unit.Location = new System.Drawing.Point(421, 225);
            this.cb_Unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Unit.Name = "cb_Unit";
            this.cb_Unit.Size = new System.Drawing.Size(286, 29);
            this.cb_Unit.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.tb_Product_Name);
            this.groupBox1.Controls.Add(this.lbl_Product_Id);
            this.groupBox1.Controls.Add(this.lbl_Product_Name);
            this.groupBox1.Controls.Add(this.cb_Category);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.tb_Product_Id);
            this.groupBox1.Location = new System.Drawing.Point(34, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1881, 101);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.FormattingEnabled = true;
            this.tb_Product_Name.Location = new System.Drawing.Point(1452, 39);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(335, 29);
            this.tb_Product_Name.TabIndex = 8;
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.Location = new System.Drawing.Point(39, 36);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(169, 34);
            this.lbl_Product_Id.TabIndex = 7;
            this.lbl_Product_Id.Text = "Product Id";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(1140, 36);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(217, 34);
            this.lbl_Product_Name.TabIndex = 7;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(694, 39);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(335, 29);
            this.cb_Category.TabIndex = 2;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(543, 36);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(136, 34);
            this.lbl_Category.TabIndex = 5;
            this.lbl_Category.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1144, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manufacture Price";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(221, 225);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(81, 34);
            this.lbl_Unit.TabIndex = 5;
            this.lbl_Unit.Text = "Unit";
            // 
            // lbl_Proportion
            // 
            this.lbl_Proportion.AutoSize = true;
            this.lbl_Proportion.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proportion.Location = new System.Drawing.Point(205, 100);
            this.lbl_Proportion.Name = "lbl_Proportion";
            this.lbl_Proportion.Size = new System.Drawing.Size(95, 34);
            this.lbl_Proportion.TabIndex = 5;
            this.lbl_Proportion.Text = "GST :";
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(1552, 318);
            this.tb_Sales_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sales_Price.MaxLength = 7;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(300, 31);
            this.tb_Sales_Price.TabIndex = 7;
            // 
            // tb_ManufacturePrice
            // 
            this.tb_ManufacturePrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ManufacturePrice.Location = new System.Drawing.Point(1555, 179);
            this.tb_ManufacturePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ManufacturePrice.MaxLength = 7;
            this.tb_ManufacturePrice.Name = "tb_ManufacturePrice";
            this.tb_ManufacturePrice.Size = new System.Drawing.Size(300, 31);
            this.tb_ManufacturePrice.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lbl_Specification);
            this.groupBox2.Controls.Add(this.txt_Description);
            this.groupBox2.Controls.Add(this.lbl_Distributor_Id);
            this.groupBox2.Controls.Add(this.txt_Distributor_Id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_Stock);
            this.groupBox2.Controls.Add(this.lbl_Sales_Price);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cb_Unit);
            this.groupBox2.Controls.Add(this.lbl_Unit);
            this.groupBox2.Controls.Add(this.lbl_Proportion);
            this.groupBox2.Controls.Add(this.tb_Sales_Price);
            this.groupBox2.Controls.Add(this.tb_ManufacturePrice);
            this.groupBox2.Controls.Add(this.tb_gst);
            this.groupBox2.Location = new System.Drawing.Point(37, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1882, 595);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Specification
            // 
            this.lbl_Specification.AutoSize = true;
            this.lbl_Specification.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Specification.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Specification.ForeColor = System.Drawing.Color.Black;
            this.lbl_Specification.Location = new System.Drawing.Point(1172, 483);
            this.lbl_Specification.Name = "lbl_Specification";
            this.lbl_Specification.Size = new System.Drawing.Size(171, 34);
            this.lbl_Specification.TabIndex = 117;
            this.lbl_Specification.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(1470, 463);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(400, 103);
            this.txt_Description.TabIndex = 116;
            // 
            // lbl_Distributor_Id
            // 
            this.lbl_Distributor_Id.AutoSize = true;
            this.lbl_Distributor_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Distributor_Id.Location = new System.Drawing.Point(1144, 67);
            this.lbl_Distributor_Id.Name = "lbl_Distributor_Id";
            this.lbl_Distributor_Id.Size = new System.Drawing.Size(228, 34);
            this.lbl_Distributor_Id.TabIndex = 115;
            this.lbl_Distributor_Id.Text = "Distributor ID";
            // 
            // txt_Distributor_Id
            // 
            this.txt_Distributor_Id.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Distributor_Id.Location = new System.Drawing.Point(1549, 67);
            this.txt_Distributor_Id.Name = "txt_Distributor_Id";
            this.txt_Distributor_Id.Size = new System.Drawing.Size(306, 31);
            this.txt_Distributor_Id.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stock";
            // 
            // tb_Stock
            // 
            this.tb_Stock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock.Location = new System.Drawing.Point(421, 362);
            this.tb_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Stock.MaxLength = 7;
            this.tb_Stock.Name = "tb_Stock";
            this.tb_Stock.Size = new System.Drawing.Size(286, 31);
            this.tb_Stock.TabIndex = 15;
            // 
            // tb_gst
            // 
            this.tb_gst.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gst.Location = new System.Drawing.Point(421, 103);
            this.tb_gst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_gst.MaxLength = 7;
            this.tb_gst.Name = "tb_gst";
            this.tb_gst.Size = new System.Drawing.Size(286, 31);
            this.tb_gst.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(682, 851);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 58);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Indigo;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(938, 851);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(180, 58);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.Panel1.Controls.Add(this.dtp);
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1924, 100);
            this.Panel1.TabIndex = 45;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(1690, 26);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 27);
            this.dtp.TabIndex = 34;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(752, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(421, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Add New Product";
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Product";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.ComboBox cb_Unit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_Proportion;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_ManufacturePrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_gst;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox tb_Product_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Stock;
        internal System.Windows.Forms.Label lbl_Distributor_Id;
        internal System.Windows.Forms.TextBox txt_Distributor_Id;
        internal System.Windows.Forms.Label lbl_Specification;
        internal System.Windows.Forms.TextBox txt_Description;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DateTimePicker dtp;
    }
}