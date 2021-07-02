namespace Annapurna_Bazar_Mgt_System.Report
{
    partial class frm_Product_P_date_wise_Report
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
            this.crv_Product_Report_date_wise = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Product_Report_date_wise
            // 
            this.crv_Product_Report_date_wise.ActiveViewIndex = -1;
            this.crv_Product_Report_date_wise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product_Report_date_wise.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product_Report_date_wise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Product_Report_date_wise.Location = new System.Drawing.Point(0, 137);
            this.crv_Product_Report_date_wise.Name = "crv_Product_Report_date_wise";
            this.crv_Product_Report_date_wise.Size = new System.Drawing.Size(1902, 816);
            this.crv_Product_Report_date_wise.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(828, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "To";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Location = new System.Drawing.Point(890, 64);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(280, 30);
            this.dtp_to.TabIndex = 16;
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Location = new System.Drawing.Point(495, 64);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(273, 30);
            this.dtp_from.TabIndex = 15;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Location = new System.Drawing.Point(1397, 59);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(155, 51);
            this.btn_Refresh.TabIndex = 14;
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
            this.btn_search.Location = new System.Drawing.Point(1215, 59);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(165, 51);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 52);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(691, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Added Date wise Report ";
            // 
            // frm_Product_P_date_wise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.crv_Product_Report_date_wise);
            this.Name = "frm_Product_P_date_wise_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Product_P_date_wise_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product_Report_date_wise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}