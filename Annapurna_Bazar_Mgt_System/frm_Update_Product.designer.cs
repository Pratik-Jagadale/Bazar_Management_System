namespace Annapurna_Bazar_Mgt_System
{
    partial class frm_Update_Product
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Distributor_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.txt_GST_Applied = new System.Windows.Forms.TextBox();
            this.lbl_Specification = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Sales_Rate = new System.Windows.Forms.Label();
            this.lbl_GST_Applied = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.Gpb_Product_Detail = new System.Windows.Forms.GroupBox();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Purchase_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Purchase_Rate = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtp_Stock_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Sales_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.lbl_Distributor_Name = new System.Windows.Forms.Label();
            this.txt_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_1s_Stock_Date = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.txt_Product_Name = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.Gpb_Product_Detail.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Indigo;
            this.btn_Search.Enabled = false;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(807, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(148, 59);
            this.btn_Search.TabIndex = 85;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Distributor_Name
            // 
            this.cmb_Distributor_Name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Distributor_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distributor_Name.FormattingEnabled = true;
            this.cmb_Distributor_Name.Location = new System.Drawing.Point(1419, 203);
            this.cmb_Distributor_Name.Name = "cmb_Distributor_Name";
            this.cmb_Distributor_Name.Size = new System.Drawing.Size(402, 44);
            this.cmb_Distributor_Name.TabIndex = 91;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Grocery",
            "Stationary"});
            this.cmb_Category.Location = new System.Drawing.Point(372, 179);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(402, 42);
            this.cmb_Category.TabIndex = 87;
            // 
            // txt_GST_Applied
            // 
            this.txt_GST_Applied.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GST_Applied.Location = new System.Drawing.Point(1419, 299);
            this.txt_GST_Applied.Name = "txt_GST_Applied";
            this.txt_GST_Applied.Size = new System.Drawing.Size(400, 43);
            this.txt_GST_Applied.TabIndex = 92;
            // 
            // lbl_Specification
            // 
            this.lbl_Specification.AutoSize = true;
            this.lbl_Specification.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Specification.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Specification.ForeColor = System.Drawing.Color.Black;
            this.lbl_Specification.Location = new System.Drawing.Point(996, 540);
            this.lbl_Specification.Name = "lbl_Specification";
            this.lbl_Specification.Size = new System.Drawing.Size(171, 34);
            this.lbl_Specification.TabIndex = 104;
            this.lbl_Specification.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(1419, 528);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(400, 103);
            this.txt_Description.TabIndex = 94;
            // 
            // lbl_Sales_Rate
            // 
            this.lbl_Sales_Rate.AutoSize = true;
            this.lbl_Sales_Rate.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Rate.Location = new System.Drawing.Point(1008, 418);
            this.lbl_Sales_Rate.Name = "lbl_Sales_Rate";
            this.lbl_Sales_Rate.Size = new System.Drawing.Size(152, 34);
            this.lbl_Sales_Rate.TabIndex = 102;
            this.lbl_Sales_Rate.Text = "Sales Rate";
            // 
            // lbl_GST_Applied
            // 
            this.lbl_GST_Applied.AutoSize = true;
            this.lbl_GST_Applied.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST_Applied.Location = new System.Drawing.Point(1001, 305);
            this.lbl_GST_Applied.Name = "lbl_GST_Applied";
            this.lbl_GST_Applied.Size = new System.Drawing.Size(188, 34);
            this.lbl_GST_Applied.TabIndex = 101;
            this.lbl_GST_Applied.Text = "GST Applied";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Indigo;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(610, 834);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(216, 79);
            this.btn_Update.TabIndex = 96;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Gpb_Product_Detail
            // 
            this.Gpb_Product_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Gpb_Product_Detail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Gpb_Product_Detail.Controls.Add(this.tb_unit);
            this.Gpb_Product_Detail.Controls.Add(this.label1);
            this.Gpb_Product_Detail.Controls.Add(this.btn_Search);
            this.Gpb_Product_Detail.Controls.Add(this.cmb_Distributor_Name);
            this.Gpb_Product_Detail.Controls.Add(this.cmb_Category);
            this.Gpb_Product_Detail.Controls.Add(this.txt_GST_Applied);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Specification);
            this.Gpb_Product_Detail.Controls.Add(this.txt_Description);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Sales_Rate);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_GST_Applied);
            this.Gpb_Product_Detail.Controls.Add(this.txt_Purchase_Rate);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Purchase_Rate);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Category);
            this.Gpb_Product_Detail.Controls.Add(this.dtp_Stock_Date);
            this.Gpb_Product_Detail.Controls.Add(this.txt_Sales_Rate);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Product_Id);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Distributor_Name);
            this.Gpb_Product_Detail.Controls.Add(this.txt_Product_Id);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_1s_Stock_Date);
            this.Gpb_Product_Detail.Controls.Add(this.lbl_Product_Name);
            this.Gpb_Product_Detail.Controls.Add(this.txt_Product_Name);
            this.Gpb_Product_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Product_Detail.Location = new System.Drawing.Point(0, 124);
            this.Gpb_Product_Detail.Name = "Gpb_Product_Detail";
            this.Gpb_Product_Detail.Size = new System.Drawing.Size(1880, 670);
            this.Gpb_Product_Detail.TabIndex = 95;
            this.Gpb_Product_Detail.TabStop = false;
            this.Gpb_Product_Detail.Text = "Product Detail";
            // 
            // tb_unit
            // 
            this.tb_unit.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unit.Location = new System.Drawing.Point(366, 393);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.Size = new System.Drawing.Size(407, 43);
            this.tb_unit.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 34);
            this.label1.TabIndex = 106;
            this.label1.Text = "Unit";
            // 
            // txt_Purchase_Rate
            // 
            this.txt_Purchase_Rate.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Purchase_Rate.Location = new System.Drawing.Point(366, 494);
            this.txt_Purchase_Rate.Name = "txt_Purchase_Rate";
            this.txt_Purchase_Rate.Size = new System.Drawing.Size(407, 43);
            this.txt_Purchase_Rate.TabIndex = 88;
            // 
            // lbl_Purchase_Rate
            // 
            this.lbl_Purchase_Rate.AutoSize = true;
            this.lbl_Purchase_Rate.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Rate.Location = new System.Drawing.Point(69, 497);
            this.lbl_Purchase_Rate.Name = "lbl_Purchase_Rate";
            this.lbl_Purchase_Rate.Size = new System.Drawing.Size(207, 34);
            this.lbl_Purchase_Rate.TabIndex = 100;
            this.lbl_Purchase_Rate.Text = "Purchase Rate";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(69, 179);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(128, 34);
            this.lbl_Category.TabIndex = 99;
            this.lbl_Category.Text = "Category";
            // 
            // dtp_Stock_Date
            // 
            this.dtp_Stock_Date.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Stock_Date.Location = new System.Drawing.Point(1419, 64);
            this.dtp_Stock_Date.Name = "dtp_Stock_Date";
            this.dtp_Stock_Date.Size = new System.Drawing.Size(400, 43);
            this.dtp_Stock_Date.TabIndex = 90;
            // 
            // txt_Sales_Rate
            // 
            this.txt_Sales_Rate.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sales_Rate.Location = new System.Drawing.Point(1419, 418);
            this.txt_Sales_Rate.Name = "txt_Sales_Rate";
            this.txt_Sales_Rate.Size = new System.Drawing.Size(400, 43);
            this.txt_Sales_Rate.TabIndex = 93;
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.Location = new System.Drawing.Point(69, 69);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(167, 34);
            this.lbl_Product_Id.TabIndex = 95;
            this.lbl_Product_Id.Text = "Product ID";
            // 
            // lbl_Distributor_Name
            // 
            this.lbl_Distributor_Name.AutoSize = true;
            this.lbl_Distributor_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Distributor_Name.Location = new System.Drawing.Point(999, 188);
            this.lbl_Distributor_Name.Name = "lbl_Distributor_Name";
            this.lbl_Distributor_Name.Size = new System.Drawing.Size(214, 34);
            this.lbl_Distributor_Name.TabIndex = 98;
            this.lbl_Distributor_Name.Text = "Distributor ID";
            // 
            // txt_Product_Id
            // 
            this.txt_Product_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Id.Location = new System.Drawing.Point(375, 66);
            this.txt_Product_Id.Name = "txt_Product_Id";
            this.txt_Product_Id.Size = new System.Drawing.Size(407, 43);
            this.txt_Product_Id.TabIndex = 84;
            this.txt_Product_Id.TextChanged += new System.EventHandler(this.txt_Product_Id_TextChanged);
            // 
            // lbl_1s_Stock_Date
            // 
            this.lbl_1s_Stock_Date.AutoSize = true;
            this.lbl_1s_Stock_Date.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1s_Stock_Date.Location = new System.Drawing.Point(999, 64);
            this.lbl_1s_Stock_Date.Name = "lbl_1s_Stock_Date";
            this.lbl_1s_Stock_Date.Size = new System.Drawing.Size(194, 34);
            this.lbl_1s_Stock_Date.TabIndex = 97;
            this.lbl_1s_Stock_Date.Text = "1s Stock Date";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(59, 287);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(205, 34);
            this.lbl_Product_Name.TabIndex = 96;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.Location = new System.Drawing.Point(365, 284);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.Size = new System.Drawing.Size(407, 43);
            this.txt_Product_Name.TabIndex = 86;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Indigo;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(1102, 834);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(230, 79);
            this.btn_Close.TabIndex = 97;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Indigo;
            this.Panel1.Controls.Add(this.lbl_Title);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1902, 100);
            this.Panel1.TabIndex = 98;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(697, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(551, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "Update / Delete Product";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Indigo;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Location = new System.Drawing.Point(848, 834);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(216, 79);
            this.btn_delete.TabIndex = 99;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // frm_Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.Gpb_Product_Detail);
            this.Controls.Add(this.btn_Close);
            this.Name = "frm_Update_Product";
            this.Text = "frm_Update_Product";
            this.Gpb_Product_Detail.ResumeLayout(false);
            this.Gpb_Product_Detail.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.ComboBox cmb_Distributor_Name;
        internal System.Windows.Forms.ComboBox cmb_Category;
        internal System.Windows.Forms.TextBox txt_GST_Applied;
        internal System.Windows.Forms.Label lbl_Specification;
        internal System.Windows.Forms.TextBox txt_Description;
        internal System.Windows.Forms.Label lbl_Sales_Rate;
        internal System.Windows.Forms.Label lbl_GST_Applied;
        internal System.Windows.Forms.Button btn_Update;
        internal System.Windows.Forms.GroupBox Gpb_Product_Detail;
        internal System.Windows.Forms.TextBox txt_Purchase_Rate;
        internal System.Windows.Forms.Label lbl_Purchase_Rate;
        internal System.Windows.Forms.Label lbl_Category;
        internal System.Windows.Forms.DateTimePicker dtp_Stock_Date;
        internal System.Windows.Forms.TextBox txt_Sales_Rate;
        internal System.Windows.Forms.Label lbl_Product_Id;
        internal System.Windows.Forms.Label lbl_Distributor_Name;
        internal System.Windows.Forms.TextBox txt_Product_Id;
        internal System.Windows.Forms.Label lbl_1s_Stock_Date;
        internal System.Windows.Forms.Label lbl_Product_Name;
        internal System.Windows.Forms.TextBox txt_Product_Name;
        internal System.Windows.Forms.Button btn_Close;
        internal System.Windows.Forms.TextBox tb_unit;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
        internal System.Windows.Forms.Button btn_delete;
    }
}