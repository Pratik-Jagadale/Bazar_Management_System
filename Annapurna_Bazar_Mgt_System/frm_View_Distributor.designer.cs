namespace Annapurna_Bazar_Mgt_System
{
    partial class frm_View_Distributor
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
            this.dgv_Distributor_Detail = new System.Windows.Forms.DataGridView();
            this.distributoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altMobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adharnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pannoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDistributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMSDataSet = new Annapurna_Bazar_Mgt_System.ABMSDataSet();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.cmb_Search_Distributor = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Distributor_By = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tbl_DistributorTableAdapter = new Annapurna_Bazar_Mgt_System.ABMSDataSetTableAdapters.tbl_DistributorTableAdapter();
            this.cb_e_name = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDistributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Distributor_Detail
            // 
            this.dgv_Distributor_Detail.AllowUserToAddRows = false;
            this.dgv_Distributor_Detail.AllowUserToDeleteRows = false;
            this.dgv_Distributor_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Distributor_Detail.AutoGenerateColumns = false;
            this.dgv_Distributor_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Distributor_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Distributor_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributoridDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.tieupdateDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.altMobilenoDataGridViewTextBoxColumn,
            this.adharnoDataGridViewTextBoxColumn,
            this.pannoDataGridViewTextBoxColumn,
            this.regnoDataGridViewTextBoxColumn});
            this.dgv_Distributor_Detail.DataSource = this.tblDistributorBindingSource;
            this.dgv_Distributor_Detail.Location = new System.Drawing.Point(34, 246);
            this.dgv_Distributor_Detail.Name = "dgv_Distributor_Detail";
            this.dgv_Distributor_Detail.ReadOnly = true;
            this.dgv_Distributor_Detail.RowTemplate.Height = 24;
            this.dgv_Distributor_Detail.Size = new System.Drawing.Size(1850, 703);
            this.dgv_Distributor_Detail.TabIndex = 117;
            // 
            // distributoridDataGridViewTextBoxColumn
            // 
            this.distributoridDataGridViewTextBoxColumn.DataPropertyName = "Distributor_id";
            this.distributoridDataGridViewTextBoxColumn.HeaderText = "Distributor_id";
            this.distributoridDataGridViewTextBoxColumn.Name = "distributoridDataGridViewTextBoxColumn";
            this.distributoridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "F_Name";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "F_Name";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "M_Name";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "M_Name";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "L_Name";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "L_Name";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tieupdateDataGridViewTextBoxColumn
            // 
            this.tieupdateDataGridViewTextBoxColumn.DataPropertyName = "Tie_up_date";
            this.tieupdateDataGridViewTextBoxColumn.HeaderText = "Tie_up_date";
            this.tieupdateDataGridViewTextBoxColumn.Name = "tieupdateDataGridViewTextBoxColumn";
            this.tieupdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            this.mobilenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altMobilenoDataGridViewTextBoxColumn
            // 
            this.altMobilenoDataGridViewTextBoxColumn.DataPropertyName = "Alt_Mobile_no";
            this.altMobilenoDataGridViewTextBoxColumn.HeaderText = "Alt_Mobile_no";
            this.altMobilenoDataGridViewTextBoxColumn.Name = "altMobilenoDataGridViewTextBoxColumn";
            this.altMobilenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adharnoDataGridViewTextBoxColumn
            // 
            this.adharnoDataGridViewTextBoxColumn.DataPropertyName = "Adhar_no";
            this.adharnoDataGridViewTextBoxColumn.HeaderText = "Adhar_no";
            this.adharnoDataGridViewTextBoxColumn.Name = "adharnoDataGridViewTextBoxColumn";
            this.adharnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pannoDataGridViewTextBoxColumn
            // 
            this.pannoDataGridViewTextBoxColumn.DataPropertyName = "Pan_no";
            this.pannoDataGridViewTextBoxColumn.HeaderText = "Pan_no";
            this.pannoDataGridViewTextBoxColumn.Name = "pannoDataGridViewTextBoxColumn";
            this.pannoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regnoDataGridViewTextBoxColumn
            // 
            this.regnoDataGridViewTextBoxColumn.DataPropertyName = "Reg_no";
            this.regnoDataGridViewTextBoxColumn.HeaderText = "Reg_no";
            this.regnoDataGridViewTextBoxColumn.Name = "regnoDataGridViewTextBoxColumn";
            this.regnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblDistributorBindingSource
            // 
            this.tblDistributorBindingSource.DataMember = "tbl_Distributor";
            this.tblDistributorBindingSource.DataSource = this.aBMSDataSet;
            // 
            // aBMSDataSet
            // 
            this.aBMSDataSet.DataSetName = "ABMSDataSet";
            this.aBMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Indigo;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(1298, 145);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(191, 61);
            this.btn_Search.TabIndex = 112;
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
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(1597, 168);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(267, 56);
            this.btn_Refresh_Grid.TabIndex = 113;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // cmb_Search_Distributor
            // 
            this.cmb_Search_Distributor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Search_Distributor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_Search_Distributor.FormattingEnabled = true;
            this.cmb_Search_Distributor.Items.AddRange(new object[] {
            "Distributor ID",
            "Mobile no"});
            this.cmb_Search_Distributor.Location = new System.Drawing.Point(470, 160);
            this.cmb_Search_Distributor.Name = "cmb_Search_Distributor";
            this.cmb_Search_Distributor.Size = new System.Drawing.Size(275, 29);
            this.cmb_Search_Distributor.TabIndex = 110;
            this.cmb_Search_Distributor.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_Distributor_SelectedIndexChanged);
            // 
            // lbl_Search_Distributor_By
            // 
            this.lbl_Search_Distributor_By.AutoSize = true;
            this.lbl_Search_Distributor_By.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Search_Distributor_By.Location = new System.Drawing.Point(83, 160);
            this.lbl_Search_Distributor_By.Name = "lbl_Search_Distributor_By";
            this.lbl_Search_Distributor_By.Size = new System.Drawing.Size(334, 34);
            this.lbl_Search_Distributor_By.TabIndex = 116;
            this.lbl_Search_Distributor_By.Text = "Search Distributor By";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Blue;
            this.btn_Close.Location = new System.Drawing.Point(870, 788);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(230, 79);
            this.btn_Close.TabIndex = 114;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // tbl_DistributorTableAdapter
            // 
            this.tbl_DistributorTableAdapter.ClearBeforeFill = true;
            // 
            // cb_e_name
            // 
            this.cb_e_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_e_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_e_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_e_name.FormattingEnabled = true;
            this.cb_e_name.Location = new System.Drawing.Point(804, 155);
            this.cb_e_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_e_name.Name = "cb_e_name";
            this.cb_e_name.Size = new System.Drawing.Size(333, 44);
            this.cb_e_name.TabIndex = 118;
            this.cb_e_name.SelectedIndexChanged += new System.EventHandler(this.cb_e_name_SelectedIndexChanged);
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
            this.Panel1.TabIndex = 119;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Palatino Linotype", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Title.Location = new System.Drawing.Point(711, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(573, 65);
            this.lbl_Title.TabIndex = 33;
            this.lbl_Title.Text = "View Distributor Details";
            // 
            // frm_View_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.cb_e_name);
            this.Controls.Add(this.dgv_Distributor_Detail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.cmb_Search_Distributor);
            this.Controls.Add(this.lbl_Search_Distributor_By);
            this.Controls.Add(this.btn_Close);
            this.Name = "frm_View_Distributor";
            this.Text = "frm_View_Distributor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_View_Distributor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Distributor_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDistributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMSDataSet)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv_Distributor_Detail;
        internal System.Windows.Forms.Button btn_Search;
        internal System.Windows.Forms.Button btn_Refresh_Grid;
        internal System.Windows.Forms.ComboBox cmb_Search_Distributor;
        internal System.Windows.Forms.Label lbl_Search_Distributor_By;
        internal System.Windows.Forms.Button btn_Close;
        private ABMSDataSet aBMSDataSet;
        private System.Windows.Forms.BindingSource tblDistributorBindingSource;
        private ABMSDataSetTableAdapters.tbl_DistributorTableAdapter tbl_DistributorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altMobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adharnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pannoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnoDataGridViewTextBoxColumn;
        internal System.Windows.Forms.ComboBox cb_e_name;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_Title;
    }
}