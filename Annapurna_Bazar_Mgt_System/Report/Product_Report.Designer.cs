namespace Annapurna_Bazar_Mgt_System.Report
{
    partial class Product_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Product_Report_date_wise
            // 
            this.crv_Product_Report_date_wise.ActiveViewIndex = -1;
            this.crv_Product_Report_date_wise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Product_Report_date_wise.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Product_Report_date_wise.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Product_Report_date_wise.Location = new System.Drawing.Point(0, 43);
            this.crv_Product_Report_date_wise.Name = "crv_Product_Report_date_wise";
            this.crv_Product_Report_date_wise.Size = new System.Drawing.Size(1902, 910);
            this.crv_Product_Report_date_wise.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(779, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Report";
            // 
            // Product_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crv_Product_Report_date_wise);
            this.Name = "Product_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Product_Report_date_wise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}