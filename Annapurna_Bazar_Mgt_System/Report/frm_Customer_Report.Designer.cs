namespace Annapurna_Bazar_Mgt_System.Report
{
    partial class frm_Customer_Report
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
            this.crv_Customer_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_name_id = new System.Windows.Forms.ComboBox();
            this.cb_by = new System.Windows.Forms.ComboBox();
            this.Rpt_customer11 = new Annapurna_Bazar_Mgt_System.RPT.Rpt_customer1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Customer_Bill
            // 
            this.crv_Customer_Bill.ActiveViewIndex = -1;
            this.crv_Customer_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Bill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_Bill.Location = new System.Drawing.Point(0, 169);
            this.crv_Customer_Bill.Name = "crv_Customer_Bill";
            this.crv_Customer_Bill.Size = new System.Drawing.Size(1902, 784);
            this.crv_Customer_Bill.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Location = new System.Drawing.Point(1097, 75);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 44);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Indigo;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Location = new System.Drawing.Point(922, 74);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(144, 44);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_name_id
            // 
            this.cb_name_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_name_id.FormattingEnabled = true;
            this.cb_name_id.Location = new System.Drawing.Point(648, 74);
            this.cb_name_id.Name = "cb_name_id";
            this.cb_name_id.Size = new System.Drawing.Size(223, 37);
            this.cb_name_id.TabIndex = 7;
            // 
            // cb_by
            // 
            this.cb_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_by.FormattingEnabled = true;
            this.cb_by.Items.AddRange(new object[] {
            "Cust_id",
            "Cust_name"});
            this.cb_by.Location = new System.Drawing.Point(366, 74);
            this.cb_by.Name = "cb_by";
            this.cb_by.Size = new System.Drawing.Size(232, 37);
            this.cb_by.TabIndex = 6;
            this.cb_by.SelectedIndexChanged += new System.EventHandler(this.cb_by_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 52);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(779, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Report";
            // 
            // frm_Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_name_id);
            this.Controls.Add(this.cb_by);
            this.Controls.Add(this.crv_Customer_Bill);
            this.Name = "frm_Customer_Report";
            this.Load += new System.EventHandler(this.frm_Customer_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Bill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_name_id;
        private System.Windows.Forms.ComboBox cb_by;
        private RPT.Rpt_customer1 Rpt_customer11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}