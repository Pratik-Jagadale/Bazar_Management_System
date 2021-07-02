namespace Annapurna_Bazar_Mgt_System.Report
{
    partial class frm_Stock_Report
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
            this.crv_Stock_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_name_id = new System.Windows.Forms.ComboBox();
            this.cb_by = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Stock_Report
            // 
            this.crv_Stock_Report.ActiveViewIndex = -1;
            this.crv_Stock_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Stock_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Stock_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Stock_Report.Location = new System.Drawing.Point(0, 137);
            this.crv_Stock_Report.Name = "crv_Stock_Report";
            this.crv_Stock_Report.Size = new System.Drawing.Size(1902, 816);
            this.crv_Stock_Report.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Location = new System.Drawing.Point(1140, 77);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(142, 36);
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
            this.btn_search.Location = new System.Drawing.Point(981, 77);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(153, 36);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_name_id
            // 
            this.cb_name_id.FormattingEnabled = true;
            this.cb_name_id.Location = new System.Drawing.Point(705, 83);
            this.cb_name_id.Name = "cb_name_id";
            this.cb_name_id.Size = new System.Drawing.Size(223, 24);
            this.cb_name_id.TabIndex = 7;
            // 
            // cb_by
            // 
            this.cb_by.FormattingEnabled = true;
            this.cb_by.Items.AddRange(new object[] {
            "Product_id"});
            this.cb_by.Location = new System.Drawing.Point(411, 83);
            this.cb_by.Name = "cb_by";
            this.cb_by.Size = new System.Drawing.Size(232, 24);
            this.cb_by.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Stock by Using :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 52);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(779, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock Report";
            // 
            // frm_Stock_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_name_id);
            this.Controls.Add(this.cb_by);
            this.Controls.Add(this.crv_Stock_Report);
            this.Name = "frm_Stock_Report";
            this.Load += new System.EventHandler(this.frm_Stock_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Stock_Report;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_name_id;
        private System.Windows.Forms.ComboBox cb_by;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}