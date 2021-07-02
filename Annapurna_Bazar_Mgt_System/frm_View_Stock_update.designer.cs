namespace Annapurna_Bazar_Mgt_System
{
    partial class frm_View_Stock_update
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
            this.dgv_Stock_Detail = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockAddedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSStock_dataset = new Annapurna_Bazar_Mgt_System.ABMSStock_dataset();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.cmb_Search_Stock = new System.Windows.Forms.ComboBox();
            this.lbl_Search__Stock_Update_By = new System.Windows.Forms.Label();
            this.cb_e_name = new System.Windows.Forms.ComboBox();
            this.tbl_StockTableAdapter = new Annapurna_Bazar_Mgt_System.ABMSStock_datasetTableAdapters.tbl_StockTableAdapter();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSStock_dataset)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Stock_Detail
            // 
            this.dgv_Stock_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Stock_Detail.AutoGenerateColumns = false;
            this.dgv_Stock_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stock_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stock_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.currentStockDataGridViewTextBoxColumn,
            this.stockAddedDateDataGridViewTextBoxColumn});
            this.dgv_Stock_Detail.DataSource = this.tblStockBindingSource;
            this.dgv_Stock_Detail.Location = new System.Drawing.Point(29, 296);
            this.dgv_Stock_Detail.Name = "dgv_Stock_Detail";
            this.dgv_Stock_Detail.RowTemplate.Height = 24;
            this.dgv_Stock_Detail.Size = new System.Drawing.Size(1849, 641);
            this.dgv_Stock_Detail.TabIndex = 116;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // currentStockDataGridViewTextBoxColumn
            // 
            this.currentStockDataGridViewTextBoxColumn.DataPropertyName = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.HeaderText = "Current_Stock";
            this.currentStockDataGridViewTextBoxColumn.Name = "currentStockDataGridViewTextBoxColumn";
            // 
            // stockAddedDateDataGridViewTextBoxColumn
            // 
            this.stockAddedDateDataGridViewTextBoxColumn.DataPropertyName = "Stock_Added_Date";
            this.stockAddedDateDataGridViewTextBoxColumn.HeaderText = "Stock_Added_Date";
            this.stockAddedDateDataGridViewTextBoxColumn.Name = "stockAddedDateDataGridViewTextBoxColumn";
            // 
            // tblStockBindingSource
            // 
            this.tblStockBindingSource.DataMember = "tbl_Stock";
            this.tblStockBindingSource.DataSource = this.aBMSStock_dataset;
            // 
            // aBMSStock_dataset
            // 
            this.aBMSStock_dataset.DataSetName = "ABMSStock_dataset";
            this.aBMSStock_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Indigo;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(1367, 171);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(243, 58);
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
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(1651, 171);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(227, 58);
            this.btn_Refresh_Grid.TabIndex = 112;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // cmb_Search_Stock
            // 
            this.cmb_Search_Stock.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search_Stock.FormattingEnabled = true;
            this.cmb_Search_Stock.Items.AddRange(new object[] {
            "Stock_ID",
            "Product_id"});
            this.cmb_Search_Stock.Location = new System.Drawing.Point(694, 192);
            this.cmb_Search_Stock.Name = "cmb_Search_Stock";
            this.cmb_Search_Stock.Size = new System.Drawing.Size(267, 42);
            this.cmb_Search_Stock.TabIndex = 109;
            this.cmb_Search_Stock.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_Stock_SelectedIndexChanged);
            // 
            // lbl_Search__Stock_Update_By
            // 
            this.lbl_Search__Stock_Update_By.AutoSize = true;
            this.lbl_Search__Stock_Update_By.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search__Stock_Update_By.Location = new System.Drawing.Point(244, 195);
            this.lbl_Search__Stock_Update_By.Name = "lbl_Search__Stock_Update_By";
            this.lbl_Search__Stock_Update_By.Size = new System.Drawing.Size(335, 34);
            this.lbl_Search__Stock_Update_By.TabIndex = 115;
            this.lbl_Search__Stock_Update_By.Text = "Search Stock Update By";
            // 
            // cb_e_name
            // 
            this.cb_e_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_e_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_e_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_e_name.FormattingEnabled = true;
            this.cb_e_name.Location = new System.Drawing.Point(991, 185);
            this.cb_e_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_e_name.Name = "cb_e_name";
            this.cb_e_name.Size = new System.Drawing.Size(333, 44);
            this.cb_e_name.TabIndex = 119;
            // 
            // tbl_StockTableAdapter
            // 
            this.tbl_StockTableAdapter.ClearBeforeFill = true;
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
            this.lbl_Title.Location = new System.Drawing.Point(761, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(447, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "View Stock Details";
            // 
            // frm_View_Stock_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cb_e_name);
            this.Controls.Add(this.dgv_Stock_Detail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.cmb_Search_Stock);
            this.Controls.Add(this.lbl_Search__Stock_Update_By);
            this.Name = "frm_View_Stock_update";
            this.Text = "frm_View_Stock_update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Stock_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stock_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSStock_dataset)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv_Stock_Detail;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.Button btn_Refresh_Grid;
        internal System.Windows.Forms.ComboBox cmb_Search_Stock;
        internal System.Windows.Forms.Label lbl_Search__Stock_Update_By;
        internal System.Windows.Forms.ComboBox cb_e_name;
        private ABMSStock_dataset aBMSStock_dataset;
        private System.Windows.Forms.BindingSource tblStockBindingSource;
        private ABMSStock_datasetTableAdapters.tbl_StockTableAdapter tbl_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockAddedDateDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}