namespace Annapurna_Bazar_Mgt_System.Report
{
    partial class frm_Customer_Date_wise_Report
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
            this.crv_Customer_Bill_date_wise = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Customer_Bill_date_wise
            // 
            this.crv_Customer_Bill_date_wise.ActiveViewIndex = -1;
            this.crv_Customer_Bill_date_wise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Bill_date_wise.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Bill_date_wise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_Bill_date_wise.Location = new System.Drawing.Point(0, 142);
            this.crv_Customer_Bill_date_wise.Name = "crv_Customer_Bill_date_wise";
            this.crv_Customer_Bill_date_wise.Size = new System.Drawing.Size(1902, 811);
            this.crv_Customer_Bill_date_wise.TabIndex = 1;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Indigo;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Location = new System.Drawing.Point(1184, 61);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 37);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Indigo;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Location = new System.Drawing.Point(1002, 61);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(154, 37);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 38);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(677, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 38);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "To";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 52);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(779, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Report";
            // 
            // frm_Customer_Date_wise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.crv_Customer_Bill_date_wise);
            this.Name = "frm_Customer_Date_wise_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Customer_Date_wise_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Bill_date_wise;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}