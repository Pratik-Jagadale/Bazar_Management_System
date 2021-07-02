namespace APMS
{
    partial class frm_Add_Stock
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
            this.lbl_New_Stock = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dtp_Mfg = new System.Windows.Forms.DateTimePicker();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Current_stock = new System.Windows.Forms.Label();
            this.btn_add_stock = new System.Windows.Forms.Button();
            this.tb_New_Stock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Mfg_Date = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_New_Stock
            // 
            this.lbl_New_Stock.AutoSize = true;
            this.lbl_New_Stock.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock.Location = new System.Drawing.Point(78, 138);
            this.lbl_New_Stock.Name = "lbl_New_Stock";
            this.lbl_New_Stock.Size = new System.Drawing.Size(160, 34);
            this.lbl_New_Stock.TabIndex = 0;
            this.lbl_New_Stock.Text = "Add Stock";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(78, 25);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(169, 34);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Product Id";
            // 
            // dtp_Mfg
            // 
            this.dtp_Mfg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtp_Mfg.Enabled = false;
            this.dtp_Mfg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Mfg.Location = new System.Drawing.Point(1461, 88);
            this.dtp_Mfg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Mfg.Name = "dtp_Mfg";
            this.dtp_Mfg.Size = new System.Drawing.Size(296, 31);
            this.dtp_Mfg.TabIndex = 4;
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Enabled = false;
            this.tb_Current_Stock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(492, 44);
            this.tb_Current_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Current_Stock.MaxLength = 5;
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(280, 31);
            this.tb_Current_Stock.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.tb_Product_Name);
            this.groupBox1.Controls.Add(this.cb_Category);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Controls.Add(this.tb_Product_ID);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Location = new System.Drawing.Point(30, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1959, 196);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.FormattingEnabled = true;
            this.tb_Product_Name.Location = new System.Drawing.Point(1469, 108);
            this.tb_Product_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(296, 29);
            this.tb_Product_Name.TabIndex = 10;
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(492, 121);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(288, 29);
            this.cb_Category.TabIndex = 9;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(492, 31);
            this.tb_Product_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Product_ID.MaxLength = 5;
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(280, 31);
            this.tb_Product_ID.TabIndex = 1;
            this.tb_Product_ID.TextChanged += new System.EventHandler(this.tb_Product_ID_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btn_Search.Enabled = false;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(840, 21);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(180, 55);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(78, 108);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(136, 34);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(1117, 114);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(95, 34);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Current_stock
            // 
            this.lbl_Current_stock.AutoSize = true;
            this.lbl_Current_stock.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_stock.Location = new System.Drawing.Point(78, 37);
            this.lbl_Current_stock.Name = "lbl_Current_stock";
            this.lbl_Current_stock.Size = new System.Drawing.Size(211, 34);
            this.lbl_Current_stock.TabIndex = 0;
            this.lbl_Current_stock.Text = "Current Stock";
            // 
            // btn_add_stock
            // 
            this.btn_add_stock.BackColor = System.Drawing.Color.White;
            this.btn_add_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_stock.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_stock.Location = new System.Drawing.Point(880, 648);
            this.btn_add_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_stock.Name = "btn_add_stock";
            this.btn_add_stock.Size = new System.Drawing.Size(242, 57);
            this.btn_add_stock.TabIndex = 6;
            this.btn_add_stock.Text = "Save";
            this.btn_add_stock.UseVisualStyleBackColor = false;
            this.btn_add_stock.Click += new System.EventHandler(this.btn_add_stock_Click);
            // 
            // tb_New_Stock
            // 
            this.tb_New_Stock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock.Location = new System.Drawing.Point(492, 138);
            this.tb_New_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_New_Stock.MaxLength = 5;
            this.tb_New_Stock.Name = "tb_New_Stock";
            this.tb_New_Stock.Size = new System.Drawing.Size(280, 31);
            this.tb_New_Stock.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lbl_Current_stock);
            this.groupBox2.Controls.Add(this.lbl_New_Stock);
            this.groupBox2.Controls.Add(this.tb_New_Stock);
            this.groupBox2.Controls.Add(this.dtp_Mfg);
            this.groupBox2.Controls.Add(this.tb_Current_Stock);
            this.groupBox2.Controls.Add(this.lbl_Mfg_Date);
            this.groupBox2.Location = new System.Drawing.Point(38, 393);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1956, 223);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Mfg_Date
            // 
            this.lbl_Mfg_Date.AutoSize = true;
            this.lbl_Mfg_Date.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mfg_Date.Location = new System.Drawing.Point(1109, 88);
            this.lbl_Mfg_Date.Name = "lbl_Mfg_Date";
            this.lbl_Mfg_Date.Size = new System.Drawing.Size(148, 34);
            this.lbl_Mfg_Date.TabIndex = 0;
            this.lbl_Mfg_Date.Text = "Mfg Date";
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
            this.Panel1.TabIndex = 45;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(793, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(373, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Add New Stock";
            // 
            // frm_Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 722);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add_stock);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Stock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_New_Stock;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DateTimePicker dtp_Mfg;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Current_stock;
        private System.Windows.Forms.Button btn_add_stock;
        private System.Windows.Forms.TextBox tb_New_Stock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Mfg_Date;
        private System.Windows.Forms.ComboBox tb_Product_Name;
        private System.Windows.Forms.ComboBox cb_Category;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}