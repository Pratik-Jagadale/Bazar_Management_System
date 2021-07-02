namespace Annapurna_Bazar_Mgt_System
{
    partial class frm_View_Product_Details
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
            this.dgv_Product_Detail = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet1 = new Annapurna_Bazar_Mgt_System.ABMSDataSet1();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.cmb_Search_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Product_By = new System.Windows.Forms.Label();
            this.tbl_ProductTableAdapter = new Annapurna_Bazar_Mgt_System.ABMSDataSet1TableAdapters.tbl_ProductTableAdapter();
            this.cb_e_name = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Product_Detail
            // 
            this.dgv_Product_Detail.AutoGenerateColumns = false;
            this.dgv_Product_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.gSTDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.distributoridDataGridViewTextBoxColumn,
            this.manufacturepriceDataGridViewTextBoxColumn,
            this.salesPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgv_Product_Detail.DataSource = this.tblProductBindingSource;
            this.dgv_Product_Detail.Location = new System.Drawing.Point(0, 283);
            this.dgv_Product_Detail.Name = "dgv_Product_Detail";
            this.dgv_Product_Detail.RowTemplate.Height = 24;
            this.dgv_Product_Detail.Size = new System.Drawing.Size(1878, 560);
            this.dgv_Product_Detail.TabIndex = 116;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // gSTDataGridViewTextBoxColumn
            // 
            this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
            this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
            this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // distributoridDataGridViewTextBoxColumn
            // 
            this.distributoridDataGridViewTextBoxColumn.DataPropertyName = "Distributor_id";
            this.distributoridDataGridViewTextBoxColumn.HeaderText = "Distributor_id";
            this.distributoridDataGridViewTextBoxColumn.Name = "distributoridDataGridViewTextBoxColumn";
            // 
            // manufacturepriceDataGridViewTextBoxColumn
            // 
            this.manufacturepriceDataGridViewTextBoxColumn.DataPropertyName = "Manufacture_price";
            this.manufacturepriceDataGridViewTextBoxColumn.HeaderText = "Manufacture_price";
            this.manufacturepriceDataGridViewTextBoxColumn.Name = "manufacturepriceDataGridViewTextBoxColumn";
            // 
            // salesPriceDataGridViewTextBoxColumn
            // 
            this.salesPriceDataGridViewTextBoxColumn.DataPropertyName = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.HeaderText = "Sales_Price";
            this.salesPriceDataGridViewTextBoxColumn.Name = "salesPriceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tbl_Product";
            this.tblProductBindingSource.DataSource = this.aBMSDataSet1;
            // 
            // aBMSDataSet1
            // 
            this.aBMSDataSet1.DataSetName = "ABMSDataSet1";
            this.aBMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Indigo;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(1300, 167);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(185, 60);
            this.btn_Search.TabIndex = 111;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh_Grid.FlatAppearance.BorderSize = 0;
            this.btn_Refresh_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh_Grid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh_Grid.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(1558, 162);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(243, 65);
            this.btn_Refresh_Grid.TabIndex = 112;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // cmb_Search_Distributor
            // 
            this.cmb_Search_Distributor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Search_Distributor.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search_Distributor.FormattingEnabled = true;
            this.cmb_Search_Distributor.Items.AddRange(new object[] {
            "Product ID",
            "Product Name"});
            this.cmb_Search_Distributor.Location = new System.Drawing.Point(460, 177);
            this.cmb_Search_Distributor.Name = "cmb_Search_Distributor";
            this.cmb_Search_Distributor.Size = new System.Drawing.Size(288, 42);
            this.cmb_Search_Distributor.TabIndex = 109;
            this.cmb_Search_Distributor.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_Distributor_SelectedIndexChanged);
            // 
            // lbl_Search_Product_By
            // 
            this.lbl_Search_Product_By.AutoSize = true;
            this.lbl_Search_Product_By.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Product_By.ForeColor = System.Drawing.Color.Black;
            this.lbl_Search_Product_By.Location = new System.Drawing.Point(117, 177);
            this.lbl_Search_Product_By.Name = "lbl_Search_Product_By";
            this.lbl_Search_Product_By.Size = new System.Drawing.Size(266, 34);
            this.lbl_Search_Product_By.TabIndex = 115;
            this.lbl_Search_Product_By.Text = "Search Product By";
            // 
            // tbl_ProductTableAdapter
            // 
            this.tbl_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // cb_e_name
            // 
            this.cb_e_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_e_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_e_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_e_name.FormattingEnabled = true;
            this.cb_e_name.Location = new System.Drawing.Point(847, 177);
            this.cb_e_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_e_name.Name = "cb_e_name";
            this.cb_e_name.Size = new System.Drawing.Size(333, 44);
            this.cb_e_name.TabIndex = 119;
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
            this.Panel1.TabIndex = 120;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(694, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(495, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "View Product Details";
            // 
            // frm_View_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cb_e_name);
            this.Controls.Add(this.dgv_Product_Detail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.cmb_Search_Distributor);
            this.Controls.Add(this.lbl_Search_Product_By);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_View_Product_Details";
            this.Text = "frm_View_Product_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Product_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv_Product_Detail;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.Button btn_Refresh_Grid;
        internal System.Windows.Forms.ComboBox cmb_Search_Distributor;
        internal System.Windows.Forms.Label lbl_Search_Product_By;
        private ABMSDataSet1 aBMSDataSet1;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private ABMSDataSet1TableAdapters.tbl_ProductTableAdapter tbl_ProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        internal System.Windows.Forms.ComboBox cb_e_name;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}